using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    private float spawnRangeX = -18.0f;
    private float spawnPosZ = 0.0f;
    private float height = .9f;
    private float startDelay = 2.0f;
    private float spawnInterval = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomObject() {
        //Spawn animals
        int itemIndex = Random.Range(0, itemPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnRangeX, height, spawnPosZ);

        Instantiate(itemPrefabs[itemIndex], spawnPos, itemPrefabs[itemIndex].transform.rotation);
    }
}
