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

    void Update()
    {
        
    }
    void UpdateText()
    {
        scoreText.text = $"Food Collected: {score}";

    }
}
