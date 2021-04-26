using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;

    public float SpawnTime = 1f;

    public bool SpawnReady = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnReady == true)
        {
            Invoke("SpawnEnemy", SpawnTime);
            Invoke("ResetSpawn", SpawnTime);
            SpawnReady = false;
        }
        
    }

    public void SpawnEnemy()
    {
        Instantiate(Enemy);
    }

    public void ResetSpawn()
    {
        SpawnReady = true;
    }
}
