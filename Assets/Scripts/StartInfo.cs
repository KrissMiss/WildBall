using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInfo : MonoBehaviour
{
    [SerializeField] GameObject StartPanel;
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            StartPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
