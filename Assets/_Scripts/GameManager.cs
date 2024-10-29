using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject BarryPrefab;
    public TextMeshProUGUI scoreTMP;
    public static int distance;
    private bool gameStarted;
    public static float Speed = 3;
    public static int EventScore;
    public static bool ScoreEvent;
    public static bool ScoreEvent2;
    // Start is called before the first frame update
    void Start()
    {
        StartNewGame();
    }


    void Update()
    {
        if (gameStarted == true && Death.Dead == false)
        {
            distance++;
            EventScore++;
            scoreTMP.text = distance.ToString();
        }
        if (EventScore == 5000)
        {
            ScoreEvent = true;
        }
        if (EventScore == 10000)
        {
            ScoreEvent2 = true;
        }
        if (EventScore > 10005)
        {
            EventScore = 0;
            ScoreEvent2 = false;
            ScoreEvent = false;
            CurveHall.onetrigger = 0;
            UpHall.test = 0;
            CurveHall.Passed = false;
            HallWays.hallspace = 0;
            Speed++;
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
        distance = 0;
        EventScore = 0;
        //reset paddle positions
        CreateNewBarry();
        ScoreEvent = false;
        ScoreEvent2 = false;
    }
}
