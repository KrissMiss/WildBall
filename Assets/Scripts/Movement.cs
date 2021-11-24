using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public int speed = 1;

    [SerializeField] Transform camera;
    [SerializeField] Text countText;

    int numScene = 0;

    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        numScene = SceneManager.GetActiveScene().buildIndex;
    }

    Vector3 move;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float Y = camera.eulerAngles.y;

        // move right
        if (Y <= 135 & Y >= 45)
        {
            move = new Vector3(vertical, 0, -horizontal);
        }

        // move forward
        else if (Y <= 360 & Y > 315 || Y < 45 & Y >= 0)
        {
            move = new Vector3(horizontal, 0, vertical);
        }

        // move back
        else if (Y < 225 & Y > 135)
        {
            move = new Vector3(-horizontal, 0, -vertical);
        }

        // move left
        if (Y <= 315 & Y >= 225)
        {
            move = new Vector3(-vertical, 0, horizontal);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(transform.position, Vector3.down, 1.7f) && (numScene == 2 || numScene == 3))
        {
            move.y = 10;
            rb.AddForce(move, ForceMode.Impulse);
            GetComponent<AudioSource>().Play();
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(move);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bonus")
        {
            count++;
            countText.text = count.ToString();
        }
    }
}
