using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //control speed 
        forwardInput = Input.GetAxis("Vertical");
        //move horizontal
        horizontalInput = Input.GetAxis("Horizontal");
     //   move vehicle forward on input
     transform.Translate(Vector3.forward*Time.deltaTime*speed * forwardInput);
        //move left and right on input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
    }
}
