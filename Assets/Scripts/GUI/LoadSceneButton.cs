using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{

    public string sceneName;

    void Start(){
        
    }

    public void loadScene(){
        SceneManager.LoadScene(sceneName);

        Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
    }

}
