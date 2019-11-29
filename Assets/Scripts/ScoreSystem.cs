using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int score;
    public Text ScoreText;

    public static void UpdateScore()
    {
        score++;
    }

    void LateUpdate()
    {
        ScoreText.text = "Score: " + score;
        if(score >= 27)
        {
            SceneManager.LoadScene(2);
        }
       
    }

}
