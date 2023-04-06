using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool canMove = false;
    public bool StageClear = false;
    public bool gameOver= false;
    public bool isStart = false;
    float timeStop = 0f;

    public static GameManager Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameStart();
    }

    private void FixedUpdate()
    {
        checkKeydown();
        if (isStart)
        {
            CountTime();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            finishGame();
        }
    }

    void gameStart()
    {
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    void checkKeydown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            canMove = true;
            isStart = true;
            UImanager.instance.ShowMenuStartGame();
        }
    }

    void finishGame()
    {
        StageClear = true;
        canMove = false;
        UImanager.instance.ShowWinningScreen();
    }

    void CountTime()
    {
        timeStop += Time.deltaTime ;
        UImanager.instance.printTime((Mathf.Round(timeStop * 1000))/1000);
        if(gameOver || StageClear)
        {
            Time.timeScale = 0f;
        }
    }
}
