using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{
    private int FoodCount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.other.gameObject.name == "Food")
        {
            Debug.Log("Have picked up food!");
            FoodCount++;

        }
    }
}
