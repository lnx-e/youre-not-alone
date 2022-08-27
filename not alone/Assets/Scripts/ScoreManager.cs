using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score = 0;
    public int newScore;


    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Update()
    {
        score += newScore;
        newScore = 0;
        text.text = score.ToString();
        Debug.Log("updated coin");
    }
}
