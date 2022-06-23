using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_1 : MonoBehaviour


{
    public float speed = 5;
    public Vector3 rotator;
    Rigidbody body;


    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = transform.forward * speed;   
        rotator = new Vector3(45, 0, 0);
    }

    void Update() 
    {
        setWheelRotation();
    }


    void setWheelRotation()
    {
        for (int i = 0; i < transform.childCount-1; i++)
        {
            transform.GetChild(i).Rotate(rotator * 2 * speed * Time.deltaTime);
        } 
    }

    void OnCollisionEnter(Collision other) 
    {
        body.isKinematic = true;   
    }
}
