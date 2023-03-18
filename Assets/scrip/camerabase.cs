using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  camerabase : MonoBehaviour
{
    [SerializeField] private float minZoomDist;
    [SerializeField] private float maxZoomDist;
    [SerializeField] private float zoomSpeed;
    [SerializeField] private float zoomModifier;

    [SerializeField] private float moveSpeed;

    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        Zoom();
        MoveByKB();
    }

    private void MoveByKB()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 dir = transform.forward * zInput + transform.right * zInput;

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    private void Zoom()
    {
        zoomModifier = Input.GetAxis("Mouse ScrollWheel");
        
        float dist = Vector3.Distance(transform.position, cam.transform.position);
        if (dist < minZoomDist && zoomModifier > 0f)
            return;
        else if (dist < minZoomDist && zoomModifier > 0f)
            return;

        cam.transform.position += cam.transform.forward * zoomModifier * zoomSpeed;

    }
}
