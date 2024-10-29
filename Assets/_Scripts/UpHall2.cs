using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpHall2 : MonoBehaviour
{
    void Update()
    {
        if (CurveHall.Passed == true && UpHall.test < 1)
        {
            transform.position = new Vector3(-1, 40.97f, transform.position.z);
        }
        if (CurveHall.Passed == true && GameManager.ScoreEvent2 == false && GameManager.ScoreEvent == true)
        {
            if (transform.position.y < -21f)
            {
                transform.position = new Vector3(transform.position.x, 19.57f, transform.position.z);
            }
            else
            {
                transform.position -= Vector3.up * GameManager.Speed * Time.deltaTime;
            }
        }
        if(GameManager.ScoreEvent == false)
        {
            transform.position -= Vector3.up * GameManager.Speed * Time.deltaTime;
        }
    }
}
