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
    public static float Speed = 3;
    public static int EventScore;
    public static bool ScoreEvent;
    public static bool ScoreEvent2;
    public static int remainder = -100;
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
            EventScore++;
            scoreTMP.text = distance.ToString();
            remainder = EventScore - 100;
        }
        if (remainder < 0)
        {
            ScoreEvent2 = false;
        }
        if (remainder == 0)
        {
            ScoreEvent = true;
        }
        if (remainder == 1000)
        {
            EventScore = 0;
            remainder = -100;
            remainder = EventScore - 100;
            ScoreEvent = false;
            ScoreEvent2 = true;
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
        EventScore = 0;
        remainder = -100;
        //reset paddle positions
        CreateNewBarry();
        ScoreEvent = false;
        ScoreEvent2 = false;
    }
}
