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

    public Image x;
    public Image instructions;
    public Image floorplan;
    
    private bool floorplanVisible = false;
    private bool instructionsVisible = false;
    
    private void Start()
    {
        ShowX();
        HideFloorplan();
        ShowInstructions();
    }

    public void CloseAll()
    {
        Debug.Log("closing all");
        HideFloorplan();
        HideInstructions();
        HideX();
    }
    
    public void Toggle(String which)
    {
        Debug.Log("toggleing");

        if (which == FLOORPLAN)
        {
            if (floorplanVisible)
            {
                HideFloorplan();
                HideInstructions();
                HideX();
            }
            else
            {
                HideInstructions();
                ShowFloorpan();
                ShowX();
            }
            
        } else if (which == INSTRUCTIONS)
        {
            if (instructionsVisible)
            {
                HideFloorplan();
                HideInstructions();
                HideX();
            }
            else
            {
                HideFloorplan();
                ShowInstructions();
                ShowX();
            }
        }
        
        
    }
    
    private void HideX()
    {
        x.GetComponent<CanvasRenderer>().SetAlpha(INVISIBLE);
    }
    private void ShowX()
    {
        x.GetComponent<CanvasRenderer>().SetAlpha(VISIBLE);
    }

    private void ShowFloorpan()
    {
        floorplanVisible = true;
        floorplan.CrossFadeAlpha(VISIBLE, CROSSFADE_TIME, false);
    }

    private void ShowInstructions()
    {
        instructionsVisible = true;
        instructions.CrossFadeAlpha(VISIBLE, CROSSFADE_TIME, false);
    }

    private void HideFloorplan()
    {
        floorplanVisible = false;
        floorplan.CrossFadeAlpha(INVISIBLE, CROSSFADE_TIME, false);
    }

    private void HideInstructions()
    {
        instructionsVisible = false;
        instructions.CrossFadeAlpha(INVISIBLE, CROSSFADE_TIME + .2f, false);
    }
}