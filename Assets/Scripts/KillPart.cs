using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPart : MonoBehaviour
{
    [SerializeField] GameObject effect1;
    [SerializeField] GameObject effect2;
    [SerializeField] GameObject innerBall;
    [SerializeField] GameObject outerBall;
    float time = 0;
    int sceneNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (innerBall == null)
        {
            time += Time.deltaTime;
            if (time >= 2)
            {
                SceneManager.LoadScene(sceneNum);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(outerBall.gameObject, 0.01f);
        Destroy(innerBall.gameObject, 0.01f);
        effect1.SetActive(true);
        effect1.GetComponent<AudioSource>().Play();
        effect2.SetActive(true);
    }
}
