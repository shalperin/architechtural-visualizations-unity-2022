using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    private bool doMove = false;
    private GameObject camera;    
    private int LERP_SPEED = 2;
    private Vector3 newPosition;
    private float MIN_DISTANCE = .2f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");

    }

    // Update is called once per frame
    void Update()
    {
        if (doMove)
            if (Vector3.Distance(camera.transform.position, newPosition) > MIN_DISTANCE)
            {
                camera.transform.position = Vector3.Lerp(camera.transform.position, newPosition, LERP_SPEED * Time.deltaTime);    
            }
            else
            {
                doMove = false;
            }
    }

    private void OnMouseDown()
    {
        newPosition = transform.position;
        newPosition.y = camera.transform.position.y;
        doMove = true;
    }

 
}
