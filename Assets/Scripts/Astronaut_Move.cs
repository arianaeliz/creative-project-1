using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronaut_Move : MonoBehaviour
{

    public float speed = 3.0f;
    public float rotSpeed = 80.0f;
    public float currentSpeed = 0.0f;
    public float accel = 10.0f;
    public float decel = 5.0f;
    public float maxSpeed = 10.0f;
    public float zoomSpeed = 20.0f;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveAstronaut();
        // float forwardInput = Input.GetAxis("Vertical");
        // forwardInput *= speed;

        // float horizontalInput = Input.GetAxis("Horizontal");
        // horizontalInput *= rotSpeed;
        // horizontalInput *= Time.deltaTime;

        // this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // this.transform.Rotate(0, horizontalInput, 0);
    }

    void MoveAstronaut()
    {
        //getting the user input for forward movement
        float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        
        //getting the user input for horizontal movement
        horizontalInput *= rotSpeed;
        horizontalInput *= Time.deltaTime;

        if(currentSpeed < maxSpeed && currentSpeed > -maxSpeed)
        {
            //add acceleration if play is applying gas
            currentSpeed += accel * forwardInput * Time.deltaTime;
        }
        else
        {
            //decelerate
            Decelerate();
        }

        //reduce current speed if player is not applying gas
        if(forwardInput == 0)
        {
            Decelerate();   
        }

        

        //moving and rotating the astronaut
        this.transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
        this.transform.Rotate(0, horizontalInput, 0);
    }
    
    void Decelerate()
    {
        if (currentSpeed > 0)
        {
            currentSpeed -= decel * Time.deltaTime;
        }
        if (currentSpeed < 0)
        {
            currentSpeed += decel * Time.deltaTime;
        }
    }
}
