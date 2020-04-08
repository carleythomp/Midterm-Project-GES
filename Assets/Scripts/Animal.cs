using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private float speed = 2;
    private Rigidbody animalRB;
    private GameObject player;
   

    void Start()
    {
        animalRB = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
       
    }

    void Update()
    {
       // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Debug.Log($"{player.transform.position} ");

        //Vector3 direction = player.transform.position - transform.position;
        transform.LookAt(player.transform.position);
        float steps = speed * Time.deltaTime;
        Vector3 playerPos = player.transform.position;
        playerPos.y = transform.position.y;
        transform.position = Vector3.MoveTowards(transform.position, playerPos, steps);

        //animalRB.AddForce(direction.normalized * speed);

        //Debug.Log(direction);
        // has direction, but nowhere to currently go because there is nothing moving it.
        // // Move our position a step closer to the target.
        //float step = speed * Time.deltaTime; // calculate distance to move
        //transform.position = Vector3.MoveTowards(transform.position, target.position, step);


        //direction.Normalize();

    }
}
