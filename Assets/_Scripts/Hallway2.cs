using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HallWay2 : MonoBehaviour
{
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
            if (HallWays.hallspace == 1)
            {
                transform.position = new Vector3(19.57f, transform.position.y, transform.position.z);
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
