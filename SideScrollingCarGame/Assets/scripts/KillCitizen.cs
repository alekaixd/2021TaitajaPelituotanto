using System.Collections;
using UnityEngine.Audio;
using System.Collections.Generic;
using UnityEngine;


public class KillCitizen : MonoBehaviour
{
    public GameObject blood;
    public AudioSource naurua;
    public GameObject explosion;
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
        Debug.Log(collision);
        if (collision.CompareTag("Enemy") == true)
        {
            
            Instantiate(explosion, transform.position, Quaternion.identity);
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver(false);
            Destroy(collision.gameObject); //destroys the "Citizen"
            gameObject.SetActive(false);
        }
        else if (collision.CompareTag("Citizen") == true)
        {
            naurua.Play();
            Instantiate(blood, transform.position, Quaternion.identity);
            GameObject.Find("GameManager").GetComponent<GameManager>().AddScore(5); //refers to "GameManager" and adds score to the score counter
            Debug.Log("adding score");
            Destroy(collision.gameObject); //destroys the "Citizen"
        }
        else
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver(true);
            gameObject.SetActive(false); //destroys the car
        }
    }

    
}
