using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeZ = 20;
    private float spawnPosX = -20;
    private float startDelay = 2;
    private float spawnInterval = 0.5f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeZ, -spawnRangeZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        
    }



}
