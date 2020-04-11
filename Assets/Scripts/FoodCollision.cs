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
            Debug.Log("Collision with food");
            source.PlayOneShot(foodCollect);
            Destroy(gameObject);
            scoreKeeper.AddText();
            
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
