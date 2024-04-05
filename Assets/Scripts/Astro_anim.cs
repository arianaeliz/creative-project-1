using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astro_anim : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
        }
        /*if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)){
            //anim.SetTrigger("wasd");
            walking = true;
            halting = false;
            
            Debug.Log("walk started");
        } 
        if(Input.GetKeyDown(KeyCode.H)){
            anim.SetTrigger("stopwalk");
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            walking = false;
            halting = true;
            
            Debug.Log("halt reached");
        }
        else {
            //anim.SetTrigger("stopwalk");
            walking = false;
            halting = true;
            
            Debug.Log("halt reached");
        }*/
        /*if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            halting = true;
        } else {
            halting = false;
        }*/

        /*if(walking == false)
        {
            anim.SetBool("ws", false);
        }
        if(walking == true)
        {
            anim.SetBool("ws", true);
        }
        if(halting == true)
        {
            anim.SetBool("halt", true);
        } 
        if(halting == false)
        {
            anim.SetBool("halt", false);
        }*/
       /* if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)){
            anim.SetTrigger("stopwalk");
        }*/
    }
}
