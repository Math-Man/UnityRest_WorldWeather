using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Taken from here, modified a bit
    //https://forum.unity.com/threads/camera-orbit-around-world-pivot-point-where-camera-position-and-rotation-orbit-together.479800/#post-4185082
    private Vector3 currentMouse;
    private Vector3 mouseDelta;
    private Vector3 lastMouse;

    public static bool activeRotate = false;
    public static Vector3 pivotPoint;

    private void Awake()
    {
        pivotPoint = Vector3.zero;
    }

    private void Update()
    {
        mouseDelta = lastMouse - currentMouse;

        if (Input.GetMouseButton(0))
        {
            activeRotate = true;
        }
        else 
        {
            activeRotate = false;
        }
        
        currentMouse = Input.mousePosition;
        mouseDelta = lastMouse - currentMouse;
    }


    void LateUpdate()
    {
        if (activeRotate)
        {
            transform.RotateAround(pivotPoint, Vector3.up, mouseDelta.x * -.1f);
            transform.RotateAround(pivotPoint, transform.right, mouseDelta.y * .1f);
        }

        lastMouse = Input.mousePosition;
    }
}

