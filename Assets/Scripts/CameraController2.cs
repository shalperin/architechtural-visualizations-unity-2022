using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController2 : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;
    private float WEBGL_SPEED = 1f;
    private float EDITOR_SPEED = 8f;
    public bool useEditorSpeed = true;
    
    private float speed = 0;  
    private int MIN_LOOK_DOWN = -35;
    private int MAX_LOOK_UP = 75;
   
    void Start()
    {
        rotation = transform.eulerAngles;
        if (useEditorSpeed)
        {
            speed = EDITOR_SPEED;
        }
        else
        {
            speed = WEBGL_SPEED;
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rotation.y += Input.GetAxis("Mouse X") * speed;
            rotation.x += -Input.GetAxis("Mouse Y") * speed;
            rotation.x = Math.Clamp(rotation.x, MIN_LOOK_DOWN, MAX_LOOK_UP);
            
            // Sam, you are cheating..  WTF does this do?
            transform.eulerAngles = (Vector2)rotation;
        }
    }
}
