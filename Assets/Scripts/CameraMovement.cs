using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private Transform player;

    public float rotSpeed = 1.5f;

    private float rotY;
    private Vector3 offset;

    private void Start()
    {
        rotY = transform.eulerAngles.y;
        offset = player.position - transform.position;
    }

    private void LateUpdate()
    {
        float horInput = Input.GetAxis("Horizontal");
        rotY += Input.GetAxis("Mouse X") * rotSpeed * 3;

        Quaternion rotation = Quaternion.Euler(0, rotY, 0);
        transform.position = player.position - (rotation * offset);
        transform.LookAt(player);
    }
}
