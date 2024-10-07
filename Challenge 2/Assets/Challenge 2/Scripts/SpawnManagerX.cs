using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    //spawnLimits/Pos X/Y
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //Spawn delay
    private float startDelay = 1.0f;
    //floats to contain a delay between 3 and 5 seconds
    private float spawnIntervalOne = 3.0f;
    private float spawnIntervalTwo = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        //randInterval
        float randInterval = Random.Range(spawnIntervalOne, spawnIntervalTwo);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        //random index 0-Length

        int indexBall = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[indexBall], spawnPos, ballPrefabs[indexBall].transform.rotation);

        Invoke("SpawnRandomBall", randInterval);
    }

}
