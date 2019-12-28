using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAction : MonoBehaviour
{

    public GameObject cannonballPrefab;
    public Transform spawnPosition;
    float lastShotTime;
    public float delayBetweenShots;
    bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lastShotTime + delayBetweenShots < Time.time)
        {
            canShoot = true;
        }
        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            GameObject newCannonball = Instantiate(cannonballPrefab, spawnPosition.position, Quaternion.identity);
            newCannonball.GetComponent<Cannonball>().SetDirection(transform.localEulerAngles);
            lastShotTime = Time.time;
            canShoot = false;
        }
    }
}
