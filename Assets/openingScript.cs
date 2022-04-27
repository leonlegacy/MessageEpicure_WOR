using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openingScript : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(LoadMainScene());
    }
    IEnumerator LoadMainScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
}
