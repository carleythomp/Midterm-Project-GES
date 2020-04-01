using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{
    ScoreKeeper scoreKeeper;
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<ScoreKeeper>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Debug.Log("Collision with food");
            Destroy(gameObject);
             
        }
       

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    GameObject other = collision.gameObject;
    //    if (other.CompareTag("Food"))
    //    {
    //        Debug.Log("Collision");
    //        GameObject.Destroy(gameObject, 1);
    //    }
    //}
    void Update()
    {
        
    }
}
