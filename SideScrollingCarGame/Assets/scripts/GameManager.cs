using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gameScore = 0;
    // Start is called before the first frame update
    public void AddScore(int score) // adds score
    {
        gameScore += score;
        Debug.Log("added score: " + gameScore);
        GameObject.Find("ScoreText").GetComponent<TMPcontroller>().UpdateScore(gameScore);
    }

    public void GameOver()
    {
        //change scene
    }
}
