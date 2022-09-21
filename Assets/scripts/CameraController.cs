using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;
    private int WEBGL_SPEED = 140;
    private int EDITOR_SPEED = 550;
    public bool useEditorSpeed = true;
    
    private float speed = 0;  
    private int MIN_LOOK_DOWN = -35;
    private int MAX_LOOK_UP = 75;
   
    void Start()  {
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
    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rotation.y += Input.GetAxis("Mouse X") * speed * Time.deltaTime;
            rotation.x += -Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
            rotation.x = Math.Clamp(rotation.x, MIN_LOOK_DOWN, MAX_LOOK_UP);
            
            // Sam, you are cheating..  WTF does this do?
            transform.eulerAngles = (Vector2)rotation;
        }
    }
}
