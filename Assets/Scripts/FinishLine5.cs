using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine5 : MonoBehaviour
{
    [SerializeField] GameObject WinningPanel;
    [SerializeField] Text count;
    [SerializeField] GameObject effect1;
    [SerializeField] GameObject effect2;
    [SerializeField] GameObject effect3;
    [SerializeField] GameObject effect4;
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (count.text == "15")
        {
            WinningPanel.SetActive(true);
            effect1.SetActive(true);
            effect2.SetActive(true);
            effect3.SetActive(true);
            effect4.SetActive(true);
            GetComponent<AudioSource>().Play();
        }
    }
}
