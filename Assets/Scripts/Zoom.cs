using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float zoomSpeed = 20.0f;
    Renderer rend;
    public float pulseSpeed = 1.0f;
    public Material[] materials;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color pigment = rend.materials[0].color;
        pigment.a = Mathf.PingPong(Time.time * pulseSpeed, 1);
        rend.materials[0].color = pigment;

        Color pigment1 = rend.materials[1].color;
        pigment1.a = Mathf.PingPong(Time.time * pulseSpeed, 2);
        rend.materials[1].color = pigment1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("astronaut"))
        {
            Debug.Log("Astronaut entered trigger");
            Astronaut_Move move = other.gameObject.GetComponent<Astronaut_Move>();
            StartCoroutine("BoostTime", move);
        }
    }

    IEnumerator BoostTime(Astronaut_Move move)
    {
        Debug.Log("Boost activated");
        move.maxSpeed += zoomSpeed;
        yield return new WaitForSeconds(5);
        move.maxSpeed -= zoomSpeed;
    }
    

}
