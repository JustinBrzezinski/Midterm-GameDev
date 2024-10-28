using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HallWays : MonoBehaviour
{
    void Update()
    {
        if (GameManager.ScoreEvent == true && GameManager.remainder < 0)
        {
            if (transform.position.x < -21f)
            {
                transform.position = new Vector3(19.57f, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position -= Vector3.right * GameManager.Speed * Time.deltaTime;
            }
        }
        else
        {
            if (transform.position.x > -21f)
            {
                transform.position -= Vector3.right * GameManager.Speed * Time.deltaTime;
            }
        }
    }
}
