using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject BarryPrefab;
    public TextMeshProUGUI scoreTMP;
    public GameObject newGameButton;
    public static int distance;
    private bool gameStarted;
    // Start is called before the first frame update
    void Start()
    {
        newGameButton.SetActive(true);
        Time.timeScale = 0;
        //Instantiate(BarryPrefab, new Vector3(-5.9f, -3.71f, 10.06f), Quaternion.Euler(new Vector3(0, 90, 0)));
    }


    void Update()
    {
        if (gameStarted == true)
        {
            distance++;
            scoreTMP.text = distance.ToString();
        }
    }
    public void CreateNewBarry()
    {
        Instantiate(BarryPrefab, new Vector3(-5.9f, -3.71f, 10.06f), Quaternion.Euler(new Vector3(0, 90, 0)));
        gameStarted = true;
    }
    public void StartNewGame()
    {
        Time.timeScale = 1;
        newGameButton.SetActive(false);
        distance = 0;
        //reset paddle positions
        CreateNewBarry();
    }
}
