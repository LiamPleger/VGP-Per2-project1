using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.CompareTag("Belt"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        } 
    }
    
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Flame"))
        {
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("TV") && other.gameObject.CompareTag("TV Drop"))
        {
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("Vase") && other.gameObject.CompareTag("Vase Drop"))
        {
            Destroy(gameObject);
        }
    }

}
