using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    public Transform[] spawnLocations;
    public GameObject[] monsters;
    public float delay;
    float monsterSpawnTime;
    public bool canSpawn;
    int monsterCounter;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= monsterSpawnTime + delay && canSpawn)
        {
            SpawnMonster();
        }
    }

    void SpawnMonster()
    {
        Instantiate(monsters[Random.Range(0, monsters.Length)], spawnLocations[Random.Range(0, spawnLocations.Length)].position, Quaternion.identity);
        monsterSpawnTime = Time.time;
        monsterCounter++;
        if (monsterCounter > 3) { delay *= 0.8f; monsterCounter = 0; }
    }

    public void ChangeSpawnerStatus(bool status)
    {
        canSpawn = status;
    }
}
