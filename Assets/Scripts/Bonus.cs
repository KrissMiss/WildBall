using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] GameObject partSys;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        partSys.SetActive(true);
    }
}
