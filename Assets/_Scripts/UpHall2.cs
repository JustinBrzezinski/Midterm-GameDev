using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpHall2 : MonoBehaviour
{
    public static int test = 0;
    void Update()
    {
        if (CurveHall.Passed == true && test < 1)
        {
            transform.position = new Vector3(-1, 40.97f, transform.position.z);
            test++;
        }
        if (transform.position.y < -21f)
        {
            transform.position = new Vector3(transform.position.x, 19.57f, transform.position.z);
        }
        else
        {
            transform.position -= Vector3.up * GameManager.Speed * Time.deltaTime;
        }
    }
}
