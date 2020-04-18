using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    ScoreKeeper scoreKeeper;
    [SerializeField] AudioClip hitSound;
    private AudioSource source;

    void Start()
    {
       GameObject player = GameObject.FindGameObjectWithTag("Player");
       scoreKeeper = player.GetComponent<ScoreKeeper>();
        source = GetComponent<AudioSource>();
        

    }


    void Update()
    {
       
       
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (scoreKeeper.score >= 5)
        {
            Destroy(gameObject);
        }
        else if (scoreKeeper.score < 0)
        {
            Destroy(gameObject);
        }
        else if (collider.gameObject.tag == "Player")
        {
            source.PlayOneShot(hitSound);
            // source.Stop();

            Destroy(gameObject, 1);

            scoreKeeper.MinusText();
        }
        
        

    }
}
