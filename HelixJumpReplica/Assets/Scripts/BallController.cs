using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce;
    [SerializeField] private GameObject splashPrefab;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision other)//Çarpıştığı anda çalışacak method;
    {
        rb.velocity = Vector3.up * jumpForce; //Vector3.up ile jumpForce verdiğimiz değeri çarparak velocity'e atadık.
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.2f,0f), transform.rotation);//splashPrefab'i Instantiete ettik.
        splash.transform.SetParent(other.gameObject.transform);//splash'ın çarptığı nesnenin child'i olmasını sağladık.
        
         
        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name; 
        //Topun çarpıştığı nesnenin MeshRenderer üzerinden ismine ulaşıyoruz.
        
        if (materialName == "UnsafeColor (Instance)")//materialName eşit ise "UnsafeColor"a;
        {
            _gameManager.PlayAgain();//gameManager içindeki PlayAgain methodu çalışsın
        }
        else if (materialName == "LastRing (Instance)")//materialName eşit ise "LastRing"e;
        {
           _gameManager.LevelSuccesful();//gameManager içindeki LevelSuccesful methodu çalışsın
        }
    }
}
