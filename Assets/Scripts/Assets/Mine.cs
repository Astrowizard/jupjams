using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public float count;
    public float power;
    public GameObject sensor;
    public Transform explosionPrefab;
    float temp;

    void OnEnable(){
        temp = count;
        sensor = transform.Find("Sensor").gameObject;
        sensor.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Mass>().Impell(transform.localRotation*Vector3.down,power);
    }

    // Update is called once per frame
    void Update()
    {
        if (temp >= 0){
            Wait();
        }
    }

    void Activate(){
        sensor.SetActive(true);
        Debug.Log("Sensor Active");
    }

    void Wait(){
        temp -= Time.deltaTime;
        if (temp <= 0){
            Activate();
        }
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.name != "Sensor"){
            Debug.Log("Mine Trigger Entered by: " + other.gameObject.name);
            Instantiate(explosionPrefab,transform.position,transform.rotation);
            Destroy(this.gameObject);
        }
    }

    void OnDisable(){
        sensor.SetActive(false);
    }
}
