using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefab;
    private float spawnRange = 9;
    [SerializeField] int animalIndex;
    void Start()
    {
        
        Instantiate(animalPrefab[animalIndex], GenerateSpawnPosition(), animalPrefab[animalIndex].transform.rotation);

        
        
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
