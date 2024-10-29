using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject Retry;
    public TextMeshProUGUI DeathText;
    public static bool Dead;
    void Start()
    {
        Dead = false;
        DeathText.gameObject.SetActive(false);
        Retry.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            DeathText.gameObject.SetActive(true);
            Retry.SetActive(true);
            Time.timeScale = 0;
            Dead = true;
        }
    }
}
