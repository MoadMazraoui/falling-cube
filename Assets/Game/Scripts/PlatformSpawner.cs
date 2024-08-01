using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
   [SerializeField] GameObject platformPrefab;

   [SerializeField] float platformSpawnTimer = 1.8f;
   [SerializeField] float currentPlatformSpawnTimer;
   [SerializeField] int platformSpawnCount;
   [SerializeField] float minX = -2f, maxX = 2f;

   private void Start() {
    currentPlatformSpawnTimer = platformSpawnTimer;
   }

   private void Update() {
        SpawnPlatforms();
   }

    private void SpawnPlatforms()
    {
        currentPlatformSpawnTimer += Time.deltaTime;

        if (currentPlatformSpawnTimer >= platformSpawnTimer)
        {
            platformSpawnCount++;

            Vector3 temp = transform.position;
            temp.x = UnityEngine.Random.Range(minX, maxX);

            GameObject newPlatform = null;

            if (platformSpawnCount < 2)
            {
                newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
            }
            else if (platformSpawnCount == 2)
            {
                if (UnityEngine.Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
            }
            else if (platformSpawnCount == 3)
            {
                if (UnityEngine.Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
            }
            else if (platformSpawnCount == 4)
            {
                if (UnityEngine.Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }

                platformSpawnCount = 0;
            }
            
            if (newPlatform)
            {
                newPlatform.transform.parent = transform;
            }

            currentPlatformSpawnTimer =0f;
        }
    }
}
