using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HallWays : MonoBehaviour
{
    public static int hallspace = 0;
    void Update()
    {
        if (GameManager.ScoreEvent == false && CurveHorizontal.passed2 == false)
        {
            if (transform.position.x < -21f)
            {
                transform.position = new Vector3(19.57f, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position -= Vector3.right * GameManager.Speed * Time.deltaTime;
            }
            if (transform.position.x < -0.22)
            {
                hallspace++;
            }
        }
        else
        {
            if (transform.position.x > -21f)
            {
                transform.position -= Vector3.right * GameManager.Speed * Time.deltaTime;
            }
            else
            {
                hallspace = 0;
            }
        }
    }
}
