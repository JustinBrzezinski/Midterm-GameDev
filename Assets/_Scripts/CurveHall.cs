using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CurveHall : MonoBehaviour
{
    public static bool Passed = false;
    // Update is called once per frame
    void Update()
    {
        if (GameManager.remainder == 0 && GameManager.ScoreEvent == true)
        {
            transform.position = new Vector3(30, transform.position.y, transform.position.z);
        }
        if (GameManager.remainder > 0)
        {
            if (transform.position.x > -13f)
            {
                transform.position -= Vector3.right * GameManager.Speed * Time.deltaTime;
            }
            else
            {
                if (transform.position.y > -22)
                {
                    transform.position += Vector3.down * GameManager.Speed * Time.deltaTime;
                }
                if (transform.position.y < -7)
                {
                    Passed = true;
                }
            }
        }
    }
}
