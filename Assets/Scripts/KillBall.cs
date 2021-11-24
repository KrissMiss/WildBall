using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBall : MonoBehaviour
{
    int numScene = 0;
    private void Start()
    {
        numScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(numScene);
        Time.timeScale = 1;
    }
}
