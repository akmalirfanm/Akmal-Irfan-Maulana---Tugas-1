using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text Myscore;
    private int ScoreNum;
    void Start()
    {
        ScoreNum = 0;
        Myscore.text = "Score : " + ScoreNum;
        
    }

    public void addScore()
    {
        ScoreNum += 20;
        Myscore.text = "Score : " + ScoreNum;
    }
}
