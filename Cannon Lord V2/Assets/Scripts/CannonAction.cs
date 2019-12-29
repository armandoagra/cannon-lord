using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonAction : MonoBehaviour
{

    public GameObject cannonballPrefab;
    public Transform spawnPosition;
    float lastShotTime;
    public float delayBetweenShots;
    bool canShoot = true;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (lastShotTime + delayBetweenShots < Time.time)
        {
            button.interactable = true;
        }
    }

    public void Fire()
    {
        GameObject newCannonball = Instantiate(cannonballPrefab, spawnPosition.position, Quaternion.identity);
        newCannonball.GetComponent<Cannonball>().SetDirection(transform.localEulerAngles);
        lastShotTime = Time.time;
        canShoot = false;
        button.interactable = false;
        GetComponent<AudioSource>().Play();
    }
}
