using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CurveHorizontal : MonoBehaviour
{
    public static bool passed2;
    void Update()
    {
        if (transform.position.x < -5)
        {
            passed2 = false;
        }
        if(transform.position.x > -5)
        {
            passed2 = true;
        }
        if (GameManager.ScoreEvent2 == true)
        {
            transform.position = new Vector3(5, 50, transform.position.z);
        }
        if (transform.position.y > 0)
            {
                transform.position -= Vector3.up * GameManager.Speed * Time.deltaTime;
            }
        else if (transform.position.x > -25f)
        {
               transform.position += Vector3.left * GameManager.Speed * Time.deltaTime;
        }
        }
    }

