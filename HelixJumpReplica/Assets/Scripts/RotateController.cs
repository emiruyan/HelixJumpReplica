using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;//Cylinder'ın dönüş hızını buradan alacağız.
    private float moveX;//x Rotation2da dönüş hızı

    private void Update()
    {
        moveX = Input.GetAxis("Mouse X");//Unity içerisinde ki MouseX'i moveX'e atadık.

        if (Input.GetMouseButton(0))//Mouse sol click'i basılı tutuluyor ise;
        {
            transform.Rotate(0f,moveX * rotateSpeed * Time.deltaTime,0f);
            //x ve z rotasyonu ila işimiz olmadığı için 0f olarak atıyoruz.
            //y'sine Input atadığımız moveX,rotateSpeed ve Time.deltaTime ile çarpıyoruz.
        }
        {
            
        }
    }
}
