using System.Collections;
using UnityEngine.Audio;
using System.Collections.Generic;
using UnityEngine;


public class KillCitizen : MonoBehaviour
{
    public GameObject blood;
    public AudioSource naurua;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
        naurua.Play();
        Instantiate(blood, transform.position, Quaternion.identity);
        Destroy(collision.gameObject); //destroys the "Citizen"
        GameObject.Find("GameManager").GetComponent<GameManager>().AddScore(100); //refers to "GameManager" and adds score to the score counter

    }

    
}
