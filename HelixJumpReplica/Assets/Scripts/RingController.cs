using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingController : MonoBehaviour
{

    [SerializeField] private Transform ballTransform;
    private GameManager _gameManager;//Game Manager classını çağırdık

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();//Game Manager classını bağladık
    }

    private void Update()
    {
        if (transform.position.y + 12.5f >= ballTransform.position.y)
        {
            Destroy(gameObject);
            _gameManager.GameScore(25);//game manager içerisindeki GameScore'a 25 ekledik
        }
    }
}
