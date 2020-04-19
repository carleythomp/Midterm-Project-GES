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
  
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);

            count++;
        }
       
    }

}
