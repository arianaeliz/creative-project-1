using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothCamera : MonoBehaviour
{
    public GameObject astronaut;
    public float cameraFllwSpd = 10.0f;
    public float cameraRotSpd = 5.0f;

    public Transform cameraOffSet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = Vector3.Lerp(this.transform.position, astronaut.transform.position, cameraFllwSpd * Time.deltaTime);

        Quaternion lookDirection;
        //Quaternion smoothRotation;

        lookDirection = Quaternion.LookRotation(astronaut.transform.forward);
        lookDirection = Quaternion.Slerp(this.transform.rotation, lookDirection, cameraRotSpd * Time.deltaTime);

        this.transform.position = cameraPos;
        this.transform.rotation = lookDirection;
      }
}
