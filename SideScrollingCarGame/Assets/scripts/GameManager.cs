using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public int gameScore = 0;
    public AudioSource boomSound;

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

        GameObject.Find("Road").GetComponent<SkyScroller>().enabled = false;
        GameObject.Find("sky shadow").GetComponent<SkyScroller>().enabled = false;
        GameObject.Find("Plane").GetComponent<SkyScroller>().enabled = false;
        GameObject.Find("sky").GetComponent<SkyScroller>().enabled = false;
        GameObject.Find("SpawnManager").SetActive(false);
        GameObject.Find("taustamusiikki").SetActive(false);
        GameObject.Find("moottorinaani").SetActive(false);
        boomSound.Play();

        StartCoroutine(WaitUntilChange(2.0f));
    }

    private IEnumerator WaitUntilChange(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Change");
        //change scene
    }
}
