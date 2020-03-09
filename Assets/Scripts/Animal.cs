using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] float speed = 2;
    private Rigidbody animalRB;
    [SerializeField] Transform player;
    private Vector3 move;

    void Start()
    {
        animalRB = GetComponent<Rigidbody>();
        player = GetComponent<Transform>();
        
    }

    void Update()
    {
        
        Vector3 direction = player.position - transform.position;
        animalRB.AddForce((player.transform.position - transform.position).normalized * speed);
        //Debug.Log(direction);
        
        
        direction.Normalize();
        move = direction;
    }
}
