using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{
    ScoreKeeper scoreKeeper;
    [SerializeField] AudioClip foodCollect;
    private AudioSource source;
    
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        scoreKeeper = player.GetComponent<ScoreKeeper>();
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            source.Stop();
            source.PlayOneShot(foodCollect);
            Destroy(gameObject, 1);
            scoreKeeper.AddText();
        }
    }
}
