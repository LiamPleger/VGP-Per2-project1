using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    //private float newSpeed = 45;
    //public bool dashMode = false;
    private PlayerController PlayerControllerScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.D)){
            //dashMode = !dashMode;
        //}
        //if(PlayerControllerScript.gameOver == false && dashMode == true) {
            //transform.Translate(Vector3.left * Time.deltaTime * newSpeed);
        //}
        if(PlayerControllerScript.gameOver == false) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) {
            Destroy(gameObject);
        }
    }
}
