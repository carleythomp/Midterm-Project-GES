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
    void Start()
    {
        score = 0;
        UpdateText();
    }

    
   public void AddText()
    {
        score++;
        UpdateText();
        if(score == 5)
        {
            Win.text = "YOU WON!";
        }
    }
   public void MinusText()
    {
        score--;
        UpdateText();
        if(score < 0)
        {
            
            Lose.text = "YOU LOSE :(";
        }
    }
   public void UpdateText()
    {
        scoreText.text = $"Food Collected: {score}";
    }
}
