using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    [SerializeField] private Transform ballTransform;//Topun transformunu buradan alacağız.
    [SerializeField] private float smoothSpeed;
    private Vector3 offset;
    

    private void Start()
    {
        offset = transform.position - ballTransform.position;//Kamera transformundan topun transformunu çıkarıp offset'e atadık.
    }

    private void Update()
    {//Vector3.Lerp ile değerler verip bunu newPos'a atadık   
        Vector3 newPos = Vector3.Lerp(transform.position, offset + ballTransform.position, smoothSpeed);
        transform.position = newPos; //newPosu transform.position'a atadık
    }
}
