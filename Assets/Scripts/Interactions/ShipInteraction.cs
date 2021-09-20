using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipInteraction : MonoBehaviour
{
    Transform capsule;
    ParticleSystem thruster;
    Mass mass;
    Quaternion targetRotation;
    GameObject activeWeapon;
    float rotationDirection = 0f;
    float rotationSpeed = 0f;
    public float smoothRot = 1f;
    float angle;

    bool go;
    bool rotate;

    float power;

    bool check = false;

    public void setPower(float f){
        power = f;
        return;
    }

    public void OnResetChanged(InputAction.CallbackContext cxt)
    {
        switch(cxt.phase){
            case InputActionPhase.Started:
                Reset();
                Debug.Log("Reset");
                break;
            case InputActionPhase.Canceled:
                break;
        }
    }    
    public void OnMovementChanged(InputAction.CallbackContext ctx)
    {
        switch(ctx.phase){
            case InputActionPhase.Started:
                Debug.Log("Movement Started");
                rotationDirection = ctx.ReadValue<float>();
                capsule.GetComponent<Capsule>().isRotating(true,rotationDirection);
                break;
            case InputActionPhase.Canceled:
                capsule.GetComponent<Capsule>().isRotating(false,0f);
                Debug.Log("Movement Ended");
                break;
        }
    }

    public void OnChangeWeapon(InputAction.CallbackContext ctx){
        switch(ctx.phase){
            case InputActionPhase.Started:
                changeWeapon();
                break;
            case InputActionPhase.Canceled:
                break;
        }
    }

    public void OnFireChanged(InputAction.CallbackContext ctx)
    {
        // Debug.Log("Fire");
        // Debug.Log(ctx);
        switch(ctx.phase){
            case InputActionPhase.Started:
                // Debug.Log("Fire");
                Fire();
                break;
            case InputActionPhase.Canceled:
                break;
        }
    }

    public void OnGoChanged(InputAction.CallbackContext ctx)
    {
        switch(ctx.phase){
            case InputActionPhase.Started:
                // Debug.Log("Go");
                go = true;
                break;
            case InputActionPhase.Canceled:
                // Debug.Log("No Go");
                go = false;
                break;
        }
    }

    public void OnCircularizeChange(InputAction.CallbackContext ctx)
    {
        switch(ctx.phase){
            case InputActionPhase.Started:
                Circularize();
                break;
            case InputActionPhase.Canceled:
                break;
        }
    }

    void OnEnable(){
        mass = this.GetComponent<Mass>();
        rotationSpeed = this.GetComponent<Ship>().rotationSpeed;
        power = this.GetComponent<Ship>().power;
        activeWeapon = this.GetComponent<Ship>().getActiveWeapon();
    }
    // Start is called before the first frame update
    void Start()
    {
        capsule = transform.GetChild(0);
        go = false;
        try{thruster = capsule.GetChild(1).GetComponent<ParticleSystem>();}
        catch{Debug.Log("No Thruster");}
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate){
            // Debug.Log("Rotating");
            // targetRotation *=  Quaternion.AngleAxis(rotationSpeed * rotationDirection, Vector3.right);
            // capsule.rotation = Quaternion.Slerp (transform.rotation, targetRotation , 10 * smoothRot * Time.deltaTime);
            
            angle += -rotationDirection * rotationSpeed;
            capsule.transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
        }
        if (go){
            //Debug.Log("Going");
            GO();
            check = true;
        }
        if (check && !go){
            thruster.Stop();
        }

    }

    private void GO(){
        mass.Thrust((capsule.localRotation*Vector3.up), power);
        if (thruster!=null){
            //Debug.Log("Thuster");
            thruster.Play();
        }
    }

    private void changeWeapon(){
        this.GetComponent<Ship>().setActiveWeapon();
        activeWeapon = this.GetComponent<Ship>().getActiveWeapon();
        Debug.Log("Active Weapon is " + activeWeapon.name);
    }

    private void Fire(){
        activeWeapon.GetComponent<Launcher>().Launch();

        // Vector3 infront = new Vector3 (0f,0f,0f) + capsule.GetChild(2).position;

        // GameObject r = Instantiate(this.GetComponent<Ship>().rocket,infront,capsule.localRotation);
        // r.GetComponent<Rigidbody>().velocity = this.GetComponent<Rigidbody>().velocity;
        // fireCount = fireRate;
    }

    private void Reset(){
        Ship s = GetComponent<Ship>();
        transform.position = s.getInitialPosition();
        transform.GetChild(0).transform.rotation = s.getInitialRotation();
    }

    private void Circularize(){
        // mass.negateVelocity();
        mass.circularize("clockwise");
    }
}
