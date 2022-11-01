using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float waitTime = 1;
    private float newTime = 0;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > newTime)
        {

            newTime = Time.time + waitTime;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        
        }
    }
}
