using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private int score;
    [SerializeField] Text scoreText;
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
            //print YOU WON
        }
    }
   public void MinusText()
    {
        score--;
        UpdateText();
        if(score < 0)
        {
            //print GAMEOVER
        }
    }
   public void UpdateText()
    {
        scoreText.text = $"Food Collected: {score}";
    }
}
