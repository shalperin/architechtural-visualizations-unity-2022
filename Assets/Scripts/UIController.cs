using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private const float CROSSFADE_TIME = .5f;
    private const string FLOORPLAN = "floorplan";
    private const string INSTRUCTIONS = "instructions";
    private const float VISIBLE = 1f;
    private const float INVISIBLE = 0f;

    public Image instructions;
    public Image floorplan;


    public bool isInMenuSystem = false;
    
    private void Start()
    {
        Debug.Log("start");
        floorplan.gameObject.SetActive(false);
        instructions.gameObject.SetActive(true);
    }

    public void CloseAll()
    {
        floorplan.gameObject.SetActive(false);
        instructions.gameObject.SetActive(false);
    }
    
    public void Toggle(String which)
    {
        if (which == FLOORPLAN)
        {
            instructions.gameObject.SetActive(false);
            floorplan.gameObject.SetActive(!floorplan.gameObject.activeSelf);
        }
        else if (which == INSTRUCTIONS)
        {
            floorplan.gameObject.SetActive(false);
            instructions.gameObject.SetActive(!instructions.gameObject.activeSelf);
        }        
    }
    
 
}


// stripped out the animation code.

// instructionsVisible = false;
//instructions.CrossFadeAlpha(INVISIBLE, CROSSFADE_TIME, false);



//if (fast)
//{
//    floorplan.GetComponent<CanvasRenderer>().SetAlpha(INVISIBLE);
//} else
//{
//    floorplan.CrossFadeAlpha(INVISIBLE, CROSSFADE_TIME, false);    
//}
//floorplanVisible = false;


//instructionsVisible = true;
//instructions.CrossFadeAlpha(VISIBLE, CROSSFADE_TIME, false);


//floorplan.CrossFadeAlpha(VISIBLE, CROSSFADE_TIME, false);
