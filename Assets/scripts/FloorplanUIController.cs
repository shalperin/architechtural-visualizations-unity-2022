using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FloorplanUIController : MonoBehaviour
{
    public Image floorplan;
    public Image x;
    public Image open;
    private float crossfadeTime = .5f;
    
    private void Start()
    {
        x.GetComponent<CanvasRenderer>().SetAlpha(0f);
        floorplan.GetComponent<CanvasRenderer>().SetAlpha(0f);
        open.GetComponent<CanvasRenderer>().SetAlpha(1f);
    }

    public void CloseFloorplan()
    {
        Debug.Log("closing floorplan");
        floorplan.CrossFadeAlpha(0f, crossfadeTime, false);
        x.CrossFadeAlpha(0f, crossfadeTime, false);
        open.CrossFadeAlpha(1f, crossfadeTime, false);
        
    }

    public void OpenFloorplan()
    {
        Debug.Log("opening floorplan");
        open.GetComponent<CanvasRenderer>().SetAlpha(0f);
        floorplan.CrossFadeAlpha(1f, crossfadeTime + .2f, false);
        x.CrossFadeAlpha(1f, crossfadeTime +.2f , false);
    
    }
}
    
    
