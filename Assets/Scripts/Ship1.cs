using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship1 : MonoBehaviour
{
    public float speedPower = .05f;
    public float rotationPower;
    float angle;

    Transform capsule;
    Rigidbody rb;

    void OnEnable(){
        rb = this.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        capsule = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
    //   if(Input.GetKey("space")){
    //       addVelocity();
    //   }
      var g = Input.GetAxis("Go");
      var x = Input.GetAxis("sHorizontal");
      var y = Input.GetAxis("sVertical");
      var a = Input.GetAxis("sRotation");
      //Debug.Log(g);
      boostVelocity(g);

      //addVelocity(new Vector3(x,y,0f));
      rotate(a);
    }

    void addVelocity(Vector3 force) {
        Debug.Log(force);
        // GetComponent<Mass>().applyForce(force * speedPower);
    }

    void boostVelocity(float boost){
        //Debug.Log("Boostin! " + boost);
        //Debug.Log(capsule.localRotation*Vector3.one);
        //Debug.Log(capsule.localRotation*Vector3.up);
        //GetComponent<Mass>().applyForce(capsule.GetComponent<Capsule>().getUnitVector() * speedPower * boost);
        rb.AddForce((capsule.localRotation*Vector3.up) * speedPower * boost);
    }

    void rotate(float rotation){
        //Debug.Log(rotation);
        angle += -rotation * rotationPower;
        capsule.transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }
}
