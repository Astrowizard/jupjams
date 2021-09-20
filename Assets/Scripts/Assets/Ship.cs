using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject[] weapons;

    public float rotationSpeed;
    public float power;
    public float fireRate;
    Vector3 initialPosition;
    Quaternion initialRotation;
    public bool circle;
    int active = 0;

    void Start(){
        this.GetComponent<ShipInteraction>().setPower(power);
        initialPosition = transform.position;
        initialRotation = transform.GetChild(0).transform.rotation;
        Debug.Log("Ship Started");
        if (circle){
            GetComponent<Mass>().circularize("clockwise");
        }
    }

    void Update(){

    }

    public void setActiveWeapon(){
        active = (active + 1) % weapons.Length;
    }

    public GameObject getActiveWeapon(){
        return weapons[active];
    }

    public Vector3 getInitialPosition(){
        return initialPosition;
    }

    public Quaternion getInitialRotation(){
        return initialRotation;
    }
}
