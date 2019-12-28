using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    public Transform[] spawnLocations;
    public GameObject monsterBat;
    public float delay;
    float monsterSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= monsterSpawnTime + delay)
        {
            SpawnMonster();
        }
    }

    void SpawnMonster()
    {
        Instantiate(monsterBat, spawnLocations[Random.Range(0, spawnLocations.Length)].position, Quaternion.identity);
        monsterSpawnTime = Time.time;
    }
}
