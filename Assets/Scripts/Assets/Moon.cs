using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Mass planet;
    public bool randomMass;

    void OnEnable(){
        if (randomMass){
            float rMass = Random.Range(500f,20000f);
            GetComponent<Mass>().setMass(rMass);
            Debug.Log("Moon Mass" + rMass);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //startPosition();
        // startVelocity();
        GetComponent<Mass>().circularize("clockwise");
        Debug.Log("Moon Started");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setRandom(bool r) {
        randomMass = r;
    }

    // void startPosition(){
    //     float xVal = 1000f;
    //     //Debug.Log("X value: " + xVal);
    //     int directionVal = Random.Range(0,2)*2-1;
    //     // Debug.Log("Direction: " + directionVal);
    //     transform.position = new Vector3(xVal * directionVal, 0f, 0f);
    //     // float a = GetComponent<Mass>().calcAcceleration(planet);
    //     // float iForce = ((a*xVal)/2) * directionVal;
    //     // Debug.Log("Initial Force: " + new Vector3(0f,iForce,0f));
    //     // GetComponent<Mass>().rb.AddForce(new Vector3(0f, iForce, 0f));
    // }

    // void startVelocity(){
    //     float xVal = this.transform.position.x;
    //     float a = GetComponent<Mass>().calcAcceleration(planet);
    //     //Debug.Log(a);
    //     float iForce = ((a*xVal)/2) * 120 * (757f/2400f);
    //     //Debug.Log("Initial Force: " + new Vector3(0f,iForce,0f));
    //     GetComponent<Mass>().Impell(new Vector3(0f, 1f, 0f),iForce);
    //     // GetComponent<Rigidbody>().velocity = new Vector3(0f,iForce,0f);
    // }
}
