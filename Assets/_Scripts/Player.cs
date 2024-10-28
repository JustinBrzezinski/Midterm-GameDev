using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public float playerSpeed = 2.0f;
    public float strafeSpeed = 0.5f;
    public float DashDistance = 5.0f;
    private Rigidbody myRb;
    private void Start()
    {
        myRb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        if (transform.position.y > 4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, transform.position.z);
        }
        if (transform.position.y < -3.9f)
        {
            transform.position = new Vector3(transform.position.x, -3.9f, transform.position.z);
        }
        if (transform.position.x < -8.5f)
        {
            transform.position = new Vector3(-8.5f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 8.85f)
        {
            transform.position = new Vector3(8.85f, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(up))
        {
            myRb.velocity = new Vector3(0,0,0);
            myRb.useGravity = false;
            transform.position += Vector3.up * playerSpeed * Time.deltaTime;
            if (Input.GetKey(left))
            {
                transform.position += Vector3.left * strafeSpeed * Time.deltaTime;
            }
            if (Input.GetKey(right))
            {
                transform.position += Vector3.right * strafeSpeed * Time.deltaTime;
            }
        }
        else if (Input.GetKeyDown(down))
        {
            transform.position += Vector3.down * DashDistance;
        }
        else if(Input.GetKey(left))
        {
            myRb.useGravity = true;
            transform.position += Vector3.left * strafeSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(right))
        {
            myRb.useGravity = true;
            transform.position += Vector3.right * strafeSpeed * Time.deltaTime;
        }
        else
        {
            myRb.useGravity = true;
        }
    }
}
