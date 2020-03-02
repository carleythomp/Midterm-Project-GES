using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    private Rigidbody animalRB;
    [SerializeField] GameObject player;

    void Start()
    {
        animalRB = GetComponent<Rigidbody>();
        //player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position.normalized);
        animalRB.AddForce(lookDirection * speed);

    }
}
