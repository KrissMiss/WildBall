
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffect : MonoBehaviour
{
    [SerializeField] GameObject effect1;
    [SerializeField] GameObject effect2;
    [SerializeField] GameObject innerBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1)
        {
            Destroy(gameObject, 0.01f);
            Destroy(innerBall.gameObject, 0.01f);
            effect1.SetActive(true);
            effect1.GetComponent<AudioSource>().Play();
            effect2.SetActive(true);
            
        }
    }
}
