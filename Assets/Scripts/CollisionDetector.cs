using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    ScoreKeeper scoreKeeper;
    [SerializeField] AudioClip hitSound;
    private AudioSource source;
    private bool hasCollided = false;
    void Start()
    {
       GameObject player = GameObject.FindGameObjectWithTag("Player");
       scoreKeeper = player.GetComponent<ScoreKeeper>();
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            hasCollided = true;
         

            
        }

    }

    void Update()
    {
        if (hasCollided == true)
        {

            source.PlayOneShot(hitSound);
           // source.Stop();

            Destroy(gameObject, 1);

            scoreKeeper.MinusText();

            hasCollided = false;
        }

    }
}
