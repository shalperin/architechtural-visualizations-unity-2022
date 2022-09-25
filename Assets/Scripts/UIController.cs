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

    public GameObject s_witch;
    public Image x;
    public Image instructions;
    public Image floorplan;
    
    private bool floorplanVisible = false;
    private bool instructionsVisible = false;

    public bool isInMenuSystem = false;
    
    private void Start()
    {
        s_witch.SetActive(true);
        ShowX();
        HideFloorplan(true);
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
        isInMenuSystem = false;
    }
    private void ShowX()
    {
        x.GetComponent<CanvasRenderer>().SetAlpha(VISIBLE);
        isInMenuSystem = true;
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

    private void HideFloorplan(bool fast = false)
    {
        if (fast)
        {
            floorplan.GetComponent<CanvasRenderer>().SetAlpha(INVISIBLE);
        } else
        {
            floorplan.CrossFadeAlpha(INVISIBLE, CROSSFADE_TIME, false);    
        }
        floorplanVisible = false;
    }

    private void HideInstructions()
    {
        instructionsVisible = false;
        instructions.CrossFadeAlpha(INVISIBLE, CROSSFADE_TIME + .2f, false);
    }
}