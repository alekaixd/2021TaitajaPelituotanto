using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gameScore = 0;
    private GameObject[] scrollingObjects;
    // Start is called before the first frame update
    public void AddScore(int score) // adds score
    {
        gameScore += score;
        Debug.Log("added score: " + gameScore);
        GameObject.Find("ScoreText").GetComponent<TMPcontroller>().UpdateScore(gameScore); // refers to another scripts function and excecutes it
    }

    public void GameOver(bool fellOffCheck)
    {
        //change scene
        Debug.Log("did fall off?: " + fellOffCheck);
        Debug.Log("Game Over!");
        
    }
}
