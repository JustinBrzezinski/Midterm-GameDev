using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UpHall : MonoBehaviour
{
    public float Speed = 3.0f;
    public static int test = 0;
    void Update()
    {
        if (CurveHall.Passed == true && test < 1)
        {
            transform.position = new Vector3(-1, 19.57f, transform.position.z);
            test++;
        }
        if (transform.position.y < -21f)
        {
            transform.position = new Vector3(transform.position.x, 19.57f, transform.position.z);
        }
        else
        {
            transform.position -= Vector3.up * Speed * Time.deltaTime;
        }
    }
}
