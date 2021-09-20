using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawShit : MonoBehaviour
{

    Vector3 p1;
    Vector3 p2;

    public Color color = Color.cyan;
    public float drawTime = 10f;

    List<Mass> pl;
    LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        try{
            pl = GetComponent<GameManager>().pl;
        }
        catch{Debug.Log("No list for Line Renderer");}
        try{
            lr = GetComponent<LineRenderer>();
        }
        catch{
            // lr = this.AddComponent<LineRenderer>();
            Debug.Log("No Line Renderer");
        }
        p1 = transform.position;
        lr.positionCount = 1;
        lr.SetPosition(0,p1);
    }

    // Update is called once per frame
    void Update()
    {
        p2 = transform.position;
        Line();
        p1 = p2;
    }
    
    void Line(){
        //Debug.DrawLine(p1,p2,color,drawTime);
        lr.positionCount += 1;
        lr.SetPosition(lr.positionCount-1,p1);
    }
}
