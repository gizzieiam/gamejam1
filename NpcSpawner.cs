using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] npcs;
    public static bool spawnAllowed;
    int randomSpawnPoint, randomNpc;
    public int count = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnANpc", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 0)
        {
            spawnAllowed = false;
        }
    }
    void SpawnANpc()
    {
        if(spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomNpc = Random.Range(0, npcs.Length);
            Instantiate(npcs[randomNpc], spawnPoints[randomSpawnPoint].position,
                Quaternion.identity);
                count = count - 1;
        }
    }
}