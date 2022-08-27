using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    int score;
    public int newScore = 0;

    public void Update()
    {
        score += newScore;
        newScore = 0;
        text.text = score.ToString();
    }
}
