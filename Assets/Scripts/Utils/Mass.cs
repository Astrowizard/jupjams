using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass : MonoBehaviour
{
    public float mass;
    public bool debug;
    float scale;
    // List<Mass> ml;
    // public Vector3 velocity;

    List<Mass> pl;
    public Rigidbody rb;
    int count;
    // ArrayList<GameObject> massObjects = new ArrayList<GameObject>();

    void OnEnable(){
        pl = FindObjectOfType<GameManager>().pl;
        pl.Add(this);
        if (rb == null){
            rb = this.GetComponent<Rigidbody>();
        }
        rb.useGravity = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.mass = mass;
        count = 5;
        // Debug.Log(velocity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Debug.Log("Update: " + generateForce(ml));
        // applyForce(generateTotalGravForce() / mass);
        // moveObject();
        if (count <= 0){
            foreach(Mass p in pl){
                if (p != this){
                    Attract(p);
                }
            }
        }
        else{count -= 1;}
    }

    void OnDisable(){
        pl.Remove(this);
    }

    public void setMass(float _mass){
        mass = _mass;
    }

    public void setScale(float _scale){
        scale = _scale;
    }

    public void Impell(Vector3 q, float power){
        rb.AddForce((q) * power,ForceMode.Impulse);
    }

    public void Thrust(Vector3 q, float power){
        rb.AddForce((q) * power);
    }

    void Attract(Mass p){
        Rigidbody rb2 = p.rb;
        Vector3 direction = rb.position - rb2.position;
        float sqDistance = direction.sqrMagnitude;
        float forceMagnitude = (scale * rb.mass * rb2.mass)/sqDistance;
        Vector3 force = direction.normalized * forceMagnitude;
        rb2.AddForce(force);
    }

    public float calcOrbitalVelocityC(Mass m){
        Rigidbody rb2 = m.rb;
        float distance = Vector3.Distance(this.transform.position,m.transform.position);
        if (debug)
        {
            Debug.Log("G: " + scale + " M: " + rb2.mass + " R: " + distance);
        }
        return Mathf.Sqrt((scale * rb2.mass) / distance);
        // return Mathf.Sqrt(pl.scale * m.mass / distance);
        // return (scale*m.mass*this.mass / distance*distance);
    }

    float calcForce(Mass m){
        Rigidbody rb2 = m.rb;
        Vector3 direction = rb.position - rb2.position;
        float sqDistance = direction.sqrMagnitude;
        return (scale * rb.mass * rb2.mass)/sqDistance; 
    }

    Mass getLargest(){
        float f1 = 0f;
        Mass big = this;
        foreach(Mass m in pl){
            if (m != this){
                float f2 = calcForce(m);
                if(f2 > f1){
                    big = m;
                    f1 = f2;
                }
            }
        }
        Debug.Log("Largest Force: " + big.name);
        return big;
    }

    public void circularize(string s){
        Mass big = getLargest();
        float distance = Vector3.Distance(this.transform.position,big.transform.position);
        float a = GetComponent<Mass>().calcOrbitalVelocityC(big);
        float iForce = a * rb.mass;
        // float iForce = ((a*distance)/2) * rb.mass * mod1 * mod2 * distance;
        Vector3 dir = Vector3.Normalize(this.transform.position - big.transform.position);
        Vector3 rDir = getRDir(dir,s);
        if (debug)
        {
            Debug.Log("IForce components: a: " + a + " d: " + distance + " m: " + rb.mass);
            Debug.Log("Unnormalized Direction Vector: " + (this.transform.position - big.transform.position));
            Debug.Log("Normalized Direction Vector: " + dir);
            Debug.Log("Tangent Vector: " + rDir);
            Debug.Log("Force: " + iForce);
        }
        GetComponent<Mass>().Impell(rDir,iForce);
    }

    Vector3 getRDir(Vector3 dir,string s){
        Vector3 rDir;
        switch(s){
            case("counter"):
                rDir = new Vector3(-dir.y,dir.x);
                break;
            case("clockwise"):
                rDir = new Vector3(dir.y,-dir.x);
                break;
            default:
                rDir = new Vector3();
                Debug.Log("No rotation vector");
                break;
        }
        return rDir;
    }

    public void negateVelocity(){
        Vector3 curVel = rb.velocity;
        Vector3 iForce = new Vector3(-curVel.x,-curVel.y,0f);
        Debug.Log("Zeroing force: " + iForce);
        Impell(iForce,1f);
        Debug.Log("Zero Velocity: " + rb.velocity);
    }


}

    // public void setScale(float scale_) {
    //     scale = scale_;
    // }

    // public void setMassList(List<Mass> ml_){
    //     ml = ml_;
    // }

    // public void applyForce(Vector3 acceleration)
    // {
      
    //     velocity+=acceleration;
    // }

    // void moveObject()
    // {
    //     if(velocity != null)
    //     {
    //         transform.Translate(velocity*Time.deltaTime);
    //     }
    // }

    // public Vector3 generateTotalGravForce()
    // {
    //     Vector3 totalForce = new Vector3(0f,0f,0f);
    //     foreach(Mass m in ml)
    //     {
    //         if (m.transform != this.transform && (this.mass != 0 | m.mass != 0)){
    //             Vector3 dirForce = calcForce(m);
    //             if(dirForce != null){
    //                 totalForce += dirForce;
    //             }
    //         }
    //     }
    //     return totalForce;
    // }
    
    // public Vector3 calcForce(Mass m){
    //     float distance = Vector3.Distance(this.transform.position,m.transform.position);
    //     float force = (scale*m.mass*this.mass) / (distance * distance);
    //     // Debug.Log("Acceleration: " + accel);
    //     Vector3 pos = Vector3.Normalize(m.transform.position - this.transform.position);
    //     // Debug.Log("Normal Vector: " + pos);
    //     Vector3 dirForce = (force * pos);
    //     dirForce = new Vector3(dirForce.x,dirForce.y,0f);
    //     return dirForce;
    // }