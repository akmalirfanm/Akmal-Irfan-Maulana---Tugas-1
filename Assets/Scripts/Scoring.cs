using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text Myscore;
    public int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        Myscore.text = "Score : " + ScoreNum;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        ScoreNum += 20;
        Myscore.text = "Score : " + ScoreNum;
    }
}
