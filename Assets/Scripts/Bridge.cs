using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{

    [SerializeField ] Animator bridge;


    private void OnCollisionEnter(Collision collision)
    {
        bridge.SetTrigger("Bridge");
        GetComponent<Animator>().SetTrigger("Bridge");
    }
}
