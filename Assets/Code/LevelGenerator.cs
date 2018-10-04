using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject coinPrefab;
    public GameObject razorPrefab;

    public int numberOfCoins = 2;
    public int numberOfRazor = 50;
    public float levelWidth = 2.5f;     //Width of camera
    public float minY = .2f;          
    public float maxY = .9f;          

    // Use this for initialization
    void Start()
    {

        Vector3 spawnPosition = new Vector3();
        Vector3 spawnRazorPosition = new Vector3();

        //Spawn random razors
        for (int i = 0; i < numberOfRazor; i++)
        {
            //Position the saw to only spawn in camera view using levelWidth
            spawnRazorPosition.y += Random.Range(minY, maxY);
            spawnRazorPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(razorPrefab, spawnRazorPosition, Quaternion.identity);
        }

        //Spawn random coins
        for (int i = 0; i < numberOfCoins; i++)
        {
            //Position the coin to only spawn in camera view using levelWidth
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }

    }
}
