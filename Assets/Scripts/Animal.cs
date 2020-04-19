using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody animalRB;
    private GameObject player;


    void Start()
    {
        animalRB = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        transform.LookAt(player.transform.position);
        float steps = speed * Time.deltaTime;
        Vector3 playerPos = player.transform.position;
        playerPos.y = transform.position.y;
        transform.position = Vector3.MoveTowards(transform.position, playerPos, steps);
    }
}
