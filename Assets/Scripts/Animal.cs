using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private float speed = 6;
    private Rigidbody animalRB;
    [SerializeField] GameObject player;
   

    void Start()
    {
        animalRB = GetComponent<Rigidbody>();
       
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        //Vector3 direction = player.position - transform.position;
        //animalRB.AddForce(direction.normalized * speed);

        //Debug.Log(direction);
       // has direction, but nowhere to currently go because there is nothing moving it.

        //direction.Normalize();

    }
}
