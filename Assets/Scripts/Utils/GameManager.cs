using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public bool empty;
    public List<Mass> pl;

    public float scale;
    public Particles particles;
    Particles pClone;
    // float count = 10;
    bool reset = false;

    void OnEnable(){
        if (!empty){
            pClone = Instantiate(particles,transform);
        }
    }
    void Start(){
        foreach (Mass p in pl){
            p.setScale(scale);
        }
    }

    void FixedUpdate(){
        if (reset && !empty){
            Reset();
            reset = false;
        }
    }

    public void OnResetChanged(InputAction.CallbackContext ctx)
    {
        switch(ctx.phase){
            case InputActionPhase.Started:
                reset = true;
                break;
        }
        Debug.Log("Pressed");
    }

    void Reset(){
        Destroy(pClone.gameObject);
        pClone = Instantiate(particles,transform);
        foreach (Mass p in pl){
            p.setScale(scale);
        }
    }

    public void OpenMenu(){
        SceneManager.LoadScene("Menu");

        Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
    }
}
