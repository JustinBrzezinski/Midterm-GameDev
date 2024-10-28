using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biglaser : MonoBehaviour
{
    void Update()
    {
        if (CurveHall.Passed == true && UpHall.test < 1)
        {
            transform.position = new Vector3(8.4f, -3, transform.position.z);
        }
    }
}
