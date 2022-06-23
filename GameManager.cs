using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject car_1;
    public GameObject taxi;
    public GameObject bus;
    public GameObject car_2;

    void Start()
    {
       StartCoroutine(Spawn()); 
    }

    IEnumerator Spawn() 
    {
        while(true)
        {
            float chooser = Random.Range(-1f, 1f);
            if (chooser > 0)
            {

            Instantiate(car_1, new Vector3(1, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(2.5f);

            Instantiate(car_2, new Vector3(-1, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(0.5f);

            Instantiate(taxi, new Vector3(1, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(1.5f);

            Instantiate(bus, new Vector3(-1.1f, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(1f);
            
            Instantiate(car_2, new Vector3(1, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(1.5f);
                
            } 
            else
            {
            Instantiate(car_1, new Vector3(-1, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(1.5f);

            Instantiate(car_2, new Vector3(1, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(0.5f);

            Instantiate(taxi, new Vector3(-1, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(1.5f);

            Instantiate(bus, new Vector3(1.1f, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(1.5f);  
            
            Instantiate(car_2, new Vector3(-1, 0.2f, 30), new Quaternion(0, -180, 0, 0));

            yield return new WaitForSeconds(2.5f); 
            }
        }
    }
}
