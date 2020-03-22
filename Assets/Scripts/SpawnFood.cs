using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    [SerializeField] GameObject[] foodPrefabs;
    private int count = 0;
    private float spawnRangeX = 60;
    private float spawnPosZ = 30;
    void Start()
    {
        
    }

    void Update()
    {
        PlacingFood();


    }

    void PlacingFood()
    {
        if (count < 5)
        {
            GameObject foodPrefab = foodPrefabs[Random.Range(0, foodPrefabs.Length)];
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX / 2, spawnRangeX / 2), 0, spawnPosZ);
            Instantiate<GameObject>(foodPrefab, spawnPos, transform.rotation);

            //hmm OH make random z position??


            count++;
        }
    }
}
