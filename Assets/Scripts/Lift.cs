using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lift : MonoBehaviour
{
    Animator anim;
    [SerializeField] GameObject Panel;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Panel.SetActive(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        Panel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("Lift");
        }
    }
}
