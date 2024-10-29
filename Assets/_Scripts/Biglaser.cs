using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biglaser : MonoBehaviour
{
    void Update()
    {
        if (CurveHall.Passed == true)
        {
            transform.position = new Vector3(-8.7f, -3, transform.position.z);
        }
        if (GameManager.ScoreEvent2 == true)
        {
            transform.position = new Vector3(15, -3, transform.position.z);
        }
    }
}
