﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    ScoreKeeper scoreKeeer;

    void Start()
    {
       GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<ScoreKeeper>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if(other.CompareTag("Player"))
        {
            Debug.Log("Collision");

        }
    }

    void Update()
    {

        
    }
}