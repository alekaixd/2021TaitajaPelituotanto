using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gameScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int score) // adds score
    {
        gameScore += score;
        Debug.Log("added score: " + gameScore);
        GameObject.Find("ScoreText").GetComponent<TMPcontroller>().UpdateScore(gameScore);
    }
}
