using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject coinPrefab;
    public GameObject razorPrefab;

    public int numberOfCoins = 50;
    public int numberOfRazor = 20;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    public float minRazor = 1;
    public float maxRazor = 10;

    // Use this for initialization
    void Start()
    {

        Vector3 spawnPosition = new Vector3();
        Vector3 spawnRazorPosition = new Vector3();

        //Spawn random razors
        for (int i = 0; i < numberOfRazor; i++)
        {
            spawnRazorPosition.y += Random.Range(minY, maxY);
            spawnRazorPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(razorPrefab, spawnRazorPosition, Quaternion.identity);
        }

        //Spawn random coins
        for (int i = 0; i < numberOfCoins; i++)
        {
            
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }

    }
}
