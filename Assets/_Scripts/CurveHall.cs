using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CurveHall : MonoBehaviour
{
    public float Speed = 3.0f;
    public static bool Passed = false;
    // Update is called once per frame
    void Update()
    {
        if (GameManager.distance == 100)
        {
            transform.position = new Vector3(30, transform.position.y, transform.position.z);
        }
        if (GameManager.distance > 100)
        {
            if (transform.position.x > -13f)
            {
                transform.position -= Vector3.right * Speed * Time.deltaTime;
            }
            else
            {
                if (transform.position.y > -22)
                {
                    transform.position += Vector3.down * Speed * Time.deltaTime;
                }
                if (transform.position.y < -7)
                {
                    Passed = true;
                }
            }
        }
    }
}
