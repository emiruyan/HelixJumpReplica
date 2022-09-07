using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce;

    private void OnCollisionEnter(Collision collision)//Çarpıştığı anda çalışacak method;
    {
        rb.velocity = Vector3.up * jumpForce; //Vector3.up ile jumpForce verdiğimiz değeri çarparak velocity'e atadık.
        //Bu method'da top ile cylinder çarpıştığı anda velocity'e atadığımız değerler devreye giriyor ve topumuz zıplamış oluyor. 
    }
}
