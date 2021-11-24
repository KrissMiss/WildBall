using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine1 : MonoBehaviour
{
    int sceneNum;
    private void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
    }
    private void OnTriggerEnter(Collider other)
    {

            SceneManager.LoadScene(sceneNum + 1);
    }
}
