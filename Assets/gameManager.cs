using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) SceneManager.LoadScene(1);
        else if (Input.GetKeyDown(KeyCode.S)) SceneManager.LoadScene(2);
    }
}
