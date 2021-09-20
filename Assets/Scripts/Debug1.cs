using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debug1 : MonoBehaviour
{
    public Canvas canvas;
    public Text text1;
    int a = 0;
    int b = 0;

    Component[] components;
    // Start is called before the first frame update
    void Start()
    {
        // canvas = this.GetComponent<Canvas>();
        Debug.Log(text1);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeText();
    }

    void ChangeText()
    {
        b += 1;
        if (b > 59){
            Debug.Log("B");
            if (a == 0){
                text1.text = "howdy";
                a = 1;    
            }
            if (a == 1){
                // text1.SetValueWithoutNotify("Bowdy");
                a = 0;
            }
        }

    }
}
