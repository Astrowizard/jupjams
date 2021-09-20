using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{

    public bool circle;
    public bool test;
    public float testForce;
    public Vector3 testVector;

    // Start is called before the first frame update
    void Start()
    {
        if (circle){
            GetComponent<Mass>().circularize("clockwise");
        }
        if (test){
            GetComponent<Mass>().Impell(new Vector3(1f,1f,0f), testForce);
            Debug.Log("Hit at force: " + testForce);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
