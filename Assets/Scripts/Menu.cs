using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }
    public void LoadLevel5()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Continue()
    {
        Time.timeScale = 1;
    }
}
