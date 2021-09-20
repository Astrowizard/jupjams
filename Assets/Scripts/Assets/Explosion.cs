using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    ParticleSystem system;
    float count;

    // Start is called before the first frame update
    void Start()
    {
        system = this.GetComponent<ParticleSystem>();
        count = 10;
        Debug.Log("Explosion Started");
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0){
            count -= Time.deltaTime;
        }
        else{
            Destroy(gameObject);
        }
    }
}
