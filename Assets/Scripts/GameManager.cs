using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static bool isplayerdead;
    static bool haswon;
    public GameObject losescreen;
    public GameObject wonscreen;
    public GameObject welcomescreen;

    void Start()
    {
        isplayerdead = false;
        losescreen.SetActive(false);
        wonscreen.SetActive(false);
        welcomescreen.SetActive(true);
        Destroy(welcomescreen, 3);
    }

    
    void Update()
    {
        if(isplayerdead)
        {
            losescreen.SetActive(true);
        }
        else if (haswon)
        {
            wonscreen.SetActive(true);
        }
    }

    public static void playerdead()
    {
        isplayerdead = true;
        ScoreSystem.score = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    
    public static void playerwon()
    {
        haswon = true;
    }
}
