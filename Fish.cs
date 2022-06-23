using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Rigidbody body;
    bool jumpPressed;
    bool isGrounded;
    Material orgMaterial;
    Renderer render;

    public float jumper;
    public Vector3 rotator;
    public Material hitMaterial;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        InvokeRepeating("Spasm", 1f, 2f); 
        render = GetComponent<Renderer>();

    }

    void Update()
    {
        if (!isGrounded)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
            rotator = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));          
        } 
    }

    void FixedUpdate() 
    {
        if(jumpPressed)
        {  
            body.AddForce(new Vector3(0.5f,10,0) * jumper, ForceMode.VelocityChange);
            transform.Rotate(rotator);
            jumpPressed = false;
        }  
    }

    void OnCollisionEnter(Collision target)
    {
        isGrounded = true;    

        if(target.gameObject.tag == "Finish")
        {
            render.sharedMaterial = hitMaterial;
            Invoke("destroy", 2f);
        }
    }

    void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }

    void Spasm()
    {
        body.AddForce(Vector3.up, ForceMode.VelocityChange);
    }

    void destroy() 
    {
        Destroy(gameObject);
    }
}
