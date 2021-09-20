using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    bool rot;
    float direction;
    float angle;
    Quaternion targetRotation;

    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rot = false;
        direction = 0;
        Vector3 axis = Vector3.forward;
        transform.rotation.ToAngleAxis(out angle,out axis);
    }

    // Update is called once per frame
    void Update()
    {
        if (rot){
            Rotate();
        }
    }

    void Rotate(){
        // Debug.Log("Rotating");
        // targetRotation *=  Quaternion.AngleAxis(rotationSpeed * direction, Vector3.forward);
        // Debug.Log(Quaternion.AngleAxis(rotationSpeed * direction, Vector3.forward));
        // Debug.Log(targetRotation);
        // transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation , .1f);
        
        angle += -direction * rotationSpeed * Time.deltaTime;
        // Debug.Log(angle);
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }

    public void isRotating(bool r, float dir){
        rot = r;
        direction = dir;
        Debug.Log(dir);
    }
}
