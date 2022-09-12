using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    private GameObject camera;    
    private Vector3 newPosition;
    float LERP_TIME = .7f; 
       
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void OnMouseDown()
    {
        newPosition = transform.position;
        newPosition.y = camera.transform.position.y;
         StartCoroutine(MoveToPosition());   
    }

    private IEnumerator MoveToPosition()
    {
        var elapsedTime = 0f;
        var startingPos = camera.transform.position;
        while (elapsedTime < LERP_TIME)
        {
            camera.transform.position = Vector3.Lerp(startingPos, newPosition, (elapsedTime / LERP_TIME));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
}
