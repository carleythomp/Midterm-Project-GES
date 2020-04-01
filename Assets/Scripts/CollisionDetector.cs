using System.Collections;
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

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("Collision with Animal");
            Destroy(gameObject, 2);

        }

    }

    void Update()
    {

        
    }
}
