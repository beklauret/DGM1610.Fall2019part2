using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireRate = 0.0f;
    public float nextFire = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(dogPrefab, transform.position, transform.rotation) as GameObject;
        }
    }
}
