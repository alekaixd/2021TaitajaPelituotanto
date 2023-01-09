using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMPcontroller : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public void UpdateScore(int score)
    {
        scoreText.text = "Blood Splattered: " + score;
        Debug.Log("updated score!");
    }
}
