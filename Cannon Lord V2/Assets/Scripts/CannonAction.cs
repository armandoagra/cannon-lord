using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAction : MonoBehaviour
{

    public GameObject cannonballPrefab;
    public Transform spawnPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newCannonball = Instantiate(cannonballPrefab, spawnPosition.position, Quaternion.identity);
            newCannonball.GetComponent<Cannonball>().SetDirection(transform.localEulerAngles);
        }
    }
}
