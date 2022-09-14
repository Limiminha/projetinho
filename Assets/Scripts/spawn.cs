using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spawn : MonoBehaviour
{

    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemy;
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 0.5f, 0.5f);
    }

    // Update is called once per frame
    public void SpawnEnemies()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[index].position, Quaternion.identity);
    }
}