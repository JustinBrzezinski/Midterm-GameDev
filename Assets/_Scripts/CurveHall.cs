using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CurveHall : MonoBehaviour
{
    public static bool Passed = false;
    public static int onetrigger = 0;
    // Update is called once per frame
    void Update()
    {
        if (GameManager.ScoreEvent == true && onetrigger < 1)
        {
            transform.position = new Vector3(30, 1.33f, transform.position.z);
            onetrigger++;
        }
        if (GameManager.ScoreEvent == true)
        {
            if (transform.position.x > -5f)
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
                if (transform.position.y < -22)
                {
                    transform.position = new Vector3(-6, -70, transform.position.z);
                }
            }
        }
    }
}
