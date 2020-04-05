using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    ScoreKeeper scoreKeeper;

    void Start()
    {
       GameObject player = GameObject.FindGameObjectWithTag("Player");
       scoreKeeper = player.GetComponent<ScoreKeeper>();
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("Collision with Animal");
            Destroy(gameObject, 2);
            scoreKeeper.MinusText();
        }

    }

    void Update()
    {

        
    }
}
