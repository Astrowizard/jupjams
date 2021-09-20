using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public Transform weapon;
    public float rof;
    public float waitTime;
    public int count;
    int cLeft;
    float cROF;
    float[] cWait;
    bool[] loaded;


    // Start is called before the first frame update
    void Start()
    {
        cLeft = count;
        cWait = new float[count];
        loaded = new bool[count];
        cROF = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (cLeft < count){
            Refresh();
        }
        if (cROF > 0){
            cROF -= Time.deltaTime;
            if (cROF <= 0){
                Debug.Log(weapon.name + " is ready to fire");
            }
        }
    }

    public void Launch(){
        if (cROF <= 0 && cLeft > 0){
            cROF = rof;
            Transform temp = Instantiate(weapon,transform.position,transform.rotation);
            temp.GetComponent<Rigidbody>().velocity = transform.parent.parent.GetComponent<Rigidbody>().velocity;
            cLeft -= 1;
            loaded[cLeft] = false;
            cWait[cLeft] = waitTime;
        }
    }

    void Refresh(){
        for (int i = 0; i < count; i += 1){
            if (cWait[i]>0){
                cWait[i] -= Time.deltaTime;
                if (cWait[i]<=0 && !loaded[i]){
                    cLeft += 1;
                    loaded[i] = true;
                    Debug.Log(weapon.name + " has " + cLeft + " loaded");
                }
            }
            
        }
    }
}
