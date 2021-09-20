using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle2 : MonoBehaviour
{
    public Rigidbody rb;
    // ParticleList list;
    void OnEnable(){
        // list = FindObjectOfType<ParticleList>();
        // list.particles.Add(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // foreach(Particle2 p in list.particles){
        //     if (p != this){
        //         Attract(p);
        //     }
        // }
    }

    // void Attract(Particle2 p){
    //     Rigidbody rb2 = p.rb;
    //     Vector3 direction = rb.position - rb2.position;
    //     float sqDistance = direction.sqrMagnitude;
    //     float forceMagnitude = (list.scale * rb.mass * rb2.mass)/sqDistance;
    //     Vector3 force = direction.normalized * forceMagnitude;
    //     rb2.AddForce(force);
    // }
}
