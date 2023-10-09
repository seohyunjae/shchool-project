using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class Caruiclick : MonoBehaviour
{

    public GameObject carcamera;
    public GameObject carui;
    public GameObject player;
    public GameObject car;
    public GameObject carin_tranform;
    public GameObject carinui;

    public static bool carin_bool;

    Carmovement carmovement;


    private void Awake()
    {
        carmovement = GetComponentInParent<Carmovement>();
    }


    public void yesOnClick()
    {
       
        carin_bool = true;
 
        carui.SetActive(false);
       

        player.transform.parent = carin_tranform.transform; 
        player.transform.position = carin_tranform.transform.position;
        player.transform.rotation = carin_tranform.transform.rotation;

        player.GetComponent<TeleportationProvider>().enabled = false; 
        player.GetComponent<DynamicMoveProvider>().enabled = false;
        player.GetComponentsInChildren<GrabMoveProvider>()[0].enabled = false;
        player.GetComponentsInChildren<GrabMoveProvider>()[1].enabled = false;



        carinui.SetActive(true);



 
    }
    public void noOnClick()
    {

        carcamera.SetActive(false);
        Carmovement carmovement = this.GetComponentInParent<Carmovement>();
        carmovement.isNoclick = true;
        carui.SetActive(false);
     
    }
}


   
