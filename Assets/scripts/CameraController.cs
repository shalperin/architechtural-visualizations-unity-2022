using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;
    public float speed = 450;  // WebGL Target 450
    
   
    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rotation.y += Input.GetAxis("Mouse X") * speed * Time.deltaTime;
            rotation.x += -Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
            rotation.x = Math.Clamp(rotation.x, -75, 75);
            
            // Sam, you are cheating..  WTF does this do?
            transform.eulerAngles = (Vector2)rotation;
        }
    }
}
