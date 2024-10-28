using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HallWays : MonoBehaviour
{
    public float Speed = 3.0f;
    void Update()
    {
        if (GameManager.distance < 100)
        {
            if (transform.position.x < -21f)
            {
                transform.position = new Vector3(19.57f, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position -= Vector3.right * Speed * Time.deltaTime;
            }
        }
        else
        {
            if (transform.position.x > -21f)
            {
                transform.position -= Vector3.right * Speed * Time.deltaTime;
            }
        }
    }
}
