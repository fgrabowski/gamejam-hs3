using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject[] powerupPrefabs;
    private float spawnRangeY = 5.0f;
    private float startDelay = 1;
    private float spawnInterval = 30f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPowerup", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomPowerup()
    {
        int powerupIndex = Random.Range(0, powerupPrefabs.Length);
        Vector3 spawnPos = new Vector2(10, Random.Range(0,spawnRangeY));

        Instantiate(powerupPrefabs[powerupIndex], spawnPos, powerupPrefabs[powerupIndex].transform.rotation);
    }
}
