using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    /* Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0,200,500);
    }*/

    public float ileriKuvvet;
    public float yanKuvvetler;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ileriKuvvet * Time.fixedDeltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(yanKuvvetler * Time.fixedDeltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-yanKuvvetler * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
