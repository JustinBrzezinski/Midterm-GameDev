using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Laser2 : MonoBehaviour
{
    Vector3 randomPosition;
    Vector3 randomRotation;
    Vector3 randomScale;
    public float rRange = 180;
    public float yRange = 3f;
    // Start is called before the first frame update
    void Start()
    {
        float scale = Random.Range(0.5f, 1.2f);
        float rPosition = Random.Range(0 - rRange, 1 + rRange);
        float yPosition = Random.Range(0 - yRange, 0 + yRange);
        float xPosition = Random.Range(45, 50);
        randomPosition = new Vector3(xPosition, yPosition, 10.3f);
        randomRotation = new Vector3(0, 0, rPosition);
        randomScale = new Vector3(scale, scale, scale);
        transform.position = randomPosition;
        transform.rotation = Quaternion.Euler(randomRotation);
        transform.localScale = randomScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (UpHall.test < 1)
        {
            if (transform.position.x < -21f)
            {
                float scale = Random.Range(0.5f, 1.2f);
                float rPosition = Random.Range(0 - rRange, 1 + rRange);
                float yPosition = Random.Range(0 - yRange, 0 + yRange);
                float xPosition = Random.Range(15, 30);
                randomPosition = new Vector3(xPosition, yPosition, 10.3f);
                randomRotation = new Vector3(0, 0, rPosition);
                randomScale = new Vector3(scale, scale, scale);
                transform.position = randomPosition;
                transform.rotation = Quaternion.Euler(randomRotation);
                transform.localScale = randomScale;
            }
            else
            {
                transform.position -= Vector3.right * GameManager.Speed * Time.deltaTime;
            }
        }
        else
        {
            if (transform.position.y < -21f)
            {
                float scale = Random.Range(0.5f, 1.2f);
                float rPosition = Random.Range(0 - rRange, 1 + rRange);
                float yPosition = Random.Range(15, 60);
                float xPosition = Random.Range(-15, 20);
                randomPosition = new Vector3(xPosition, yPosition, 10.3f);
                randomRotation = new Vector3(0, 0, rPosition);
                randomScale = new Vector3(scale, scale, scale);
                transform.position = randomPosition;
                transform.rotation = Quaternion.Euler(randomRotation);
                transform.localScale = randomScale;
            }
            else
            {
                transform.position -= Vector3.up * GameManager.Speed * Time.deltaTime;
            }
        }
    }
}

