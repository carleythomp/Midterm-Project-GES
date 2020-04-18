using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private int score;
    [SerializeField] Text scoreText;
    [SerializeField] Text Win;
    [SerializeField] Text Lose;
    PlayerMove playerMoving;
    CollisionDetector animalCollision;
   
    void Start()
    {
        score = 0;
        UpdateText();
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject animal = GameObject.FindGameObjectWithTag("Animals");
        animalCollision = animal.GetComponent<CollisionDetector>();
        playerMoving = player.GetComponent<PlayerMove>();
       
    }

    
   public void AddText()
    {
        score++;
        UpdateText();
        if(score == 5)
        {
            Win.text = "YOU WON!";
            playerMoving.enabled = false;
            animalCollision.enabled = false;
            
        }
    }
   public void MinusText()
    {
        score--;
        UpdateText();
        if (score < 0)
        {
            playerMoving.enabled = false;
            Lose.text = "YOU LOSE :(";
            animalCollision.enabled = false;
        }
    }
   public void UpdateText()
    {
        scoreText.text = $"Food Collected: {score}";
    }
}
