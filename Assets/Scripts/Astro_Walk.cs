using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astro_Walk : MonoBehaviour
{

    public float speed = 1.0f;
    public float rotSpeed = 80.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        forwardInput *= speed;

       /* float horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput *= rotSpeed;
        horizontalInput *= Time.deltaTime;*/

        this.transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);
        //this.transform.Rotate(0, horizontalInput, 0);
    }
}
