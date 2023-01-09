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
        if(collision.CompareTag("Enemy") == true)
        {
            Destroy(collision.gameObject); //destroys the "Citizen"
        }
        else
        {
            naurua.Play();
            Instantiate(blood, transform.position, Quaternion.identity);
            GameObject.Find("GameManager").GetComponent<GameManager>().AddScore(5); //refers to "GameManager" and adds score to the score counter
            Debug.Log("adding score");
            Destroy(collision.gameObject); //destroys the "Citizen"
        }
    }

    
}
