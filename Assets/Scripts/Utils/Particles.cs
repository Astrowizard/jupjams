using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{

    List<Mass> massList = new List<Mass>();
    public Mass planet;
    // public float scale=.01f;
    public Mass moon;
    public Mass[] ships;

    public bool rand;
    public bool moons;
    public bool locate;

    public float shipHeight;
    public float moonHeight;

    public float[] moonRandomRange = new float[2];
    public float[] shipRandomRange = new float[2];

    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(planet,new Vector3(0f,0f,0f),new Quaternion(0f,0f,0f,0f),transform);

        if (moons){
            createMoons();
        }
        placeShips();

        // Mass s = Instantiate (ship, transform);
        // Mass p = Instantiate(planet,transform);
        // Mass m1 = Instantiate(moon1,transform);
        // Mass m2 = Instantiate(moon2,transform);
        // massList.Add(p);
        // massList.Add(m1);
        // massList.Add(m2);
        // massList.Add(s);
        // foreach(Mass m in massList){
        //     m.setScale(scale);
        //     m.setMassList(massList);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createMoons(){
        float[] d;
        Vector3[] pos;
        int n;
        if (rand){
            n = Mathf.RoundToInt(Random.value * 4);
            d = new float[n];
            pos = new Vector3[n];
            for (int i = 0; i < n; i+=1){
                d[i] = Random.Range(moonRandomRange[0],moonRandomRange[1]);
                pos[i] = Vector3.Normalize(Random.insideUnitCircle);
                pos[i].z = 0f;
            }
        }
        else{
            n = 1;
            d = new float[] {moonHeight};
            pos = new Vector3[] {Vector3.Normalize(Random.insideUnitCircle)};
        }
        for (int i = 0; i < n; i+=1){
            Debug.Log("Moon " + i + " Position: " + pos[i] * d[i]);
            Mass temp = Instantiate(moon,pos[i] * d[i],new Quaternion(0f,0f,0f,0f),transform);
            temp.GetComponent<Moon>().setRandom(rand);
        }
    }

    void placeShips(){
        float d = shipHeight;
        Mass temp;
        Vector3 pos = new Vector3(d,0f,0f);
        Debug.Log("Ship Array Length: " + ships.Length);
        for (int i = 0; i <= ships.Length; i+=1){
            if (rand){
                d = Random.Range(shipRandomRange[0],shipRandomRange[1]);
                pos = Vector3.Normalize(Random.insideUnitCircle);
            }
            temp = Instantiate(ships[i],pos * d,new Quaternion(0f,0f,0f,0f),transform);
            temp.transform.Find("Locator").gameObject.SetActive(locate);
            pos *= -1;
        }
        
    }
}
