using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obsticlePrefab;
    public Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 3;
    private PlayerController playercontrollerScript;
   
    // Start is called before the first frame update
    void Start()
    {
        playercontrollerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObsticle", startDelay, repeatRate);
        
    }

    // Update is called once per frame
    void Update()
    {        
    }

    void SpawnObsticle () {
        if (playercontrollerScript.gameOver == false){
            Instantiate(obsticlePrefab, spawnPos, obsticlePrefab.transform.rotation);

        }
        


    }
}
