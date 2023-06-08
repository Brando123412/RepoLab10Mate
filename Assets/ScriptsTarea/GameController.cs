using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject scena2D;
    [SerializeField] GameObject scena3D;
    [SerializeField] Camera camaraReferences;
    bool cambioCamara = false;
    //[SerializeField] LayerMask[] layer;
    public void PresetButoon(){
        if(cambioCamara == true){
            cambioCamara=false;
            scena2D.SetActive(true);
            scena3D.SetActive(false);
            camaraReferences.orthographic = true;
            //camaraReferences.cullingMask = layer[1];
    
        }else{
            camaraReferences.orthographic = false;
            cambioCamara=true;
            scena2D.SetActive(false);
            scena3D.SetActive(true);
            //camaraReferences.cullingMask = layer[0];
        }
    }
}
