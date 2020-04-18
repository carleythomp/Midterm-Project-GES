using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefab;
    private float spawnIntervals = 5.0f;
    private float spawnDelay = 4.0f;
    private float spawnRangeX = 5;
    private float spawnPosZ = 8;
    private int count = 0;
    
    void Start()
    {
       // InvokeRepeating("MakingAnimals", spawnDelay, spawnIntervals);
    }

    void Update()
    {
       
        if(spawnDelay <= 0f)
        {
            MakingAnimals();
            spawnDelay = spawnIntervals;
        }

        spawnDelay -= Time.deltaTime;
    }


    public void MakingAnimals()
    {
        if(count < 5 )
        {
            int animalIndex = Random.Range(0, animalPrefab.Length);
            //Quaternion randomRotation = Random.rotationUniform;
            //Vector3 spawnPosition = transform.position + transform.forward * 0.5f;
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);


            
            //if (transform.position.x < -xRange)
            //{
            //    transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            //}
            //if (transform.position.x > xRange)
            //{
            //    transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            //}
           // Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
            count++;
        }
       
    }

}
