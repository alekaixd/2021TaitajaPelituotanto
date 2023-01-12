using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform[] spawnPoints;
    public bool spawningObjects = true;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy(Random.Range(1, 3)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemy(float interval)
    {
        if(spawningObjects == true)
        {
            yield return new WaitForSeconds(interval);
            int randomSpawnpoint = Random.Range(0, spawnPoints.Length);
            int randomCitizen = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[randomCitizen], spawnPoints[randomSpawnpoint]);
            StartCoroutine(SpawnEnemy(Random.Range(1, 3)));
        }
    }
}
