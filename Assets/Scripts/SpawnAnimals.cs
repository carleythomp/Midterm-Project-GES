using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefab;
    [SerializeField] bool stopSpawning = false;
    [SerializeField] float spawnTime;
    [SerializeField] float spawnDelay;

    void Start()
    {
        InvokeRepeating("MakingAnimals", 2.0f, 0.3f);
    }

    void MakingAnimals()
    {
        Quaternion randomRotation = Random.rotationUniform;
        Vector3 spawnPosition = transform.position + transform.forward * 0.5f;
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Instantiate(animalPrefab[animalIndex], spawnPosition, randomRotation);
    }

}
