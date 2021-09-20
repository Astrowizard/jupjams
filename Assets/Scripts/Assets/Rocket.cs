using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float power;
    public float seconds;
    Mass mass;
    Collider warhead;
    ParticleSystem thrust;

    public Transform explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        mass = this.GetComponent<Mass>();
        foreach(Transform t in this.transform){
            if (t.tag == "warhead"){
                warhead = t.GetComponent<Collider>();
            }
            if (t.tag == "thruster"){
                thrust = t.GetComponent<ParticleSystem>();
            }
        }
        Debug.Log("Rocket started");
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds > 0){
            seconds -= Time.deltaTime;
            mass.Thrust((this.transform.localRotation*Vector3.up),power);
            thrust.Play();
        }
        else{
            thrust.Stop();
        }
    }

    void OnCollisionEnter(Collision collision){
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        Instantiate(explosionPrefab,position,rotation);
        Destroy(this.gameObject);
    }

}
