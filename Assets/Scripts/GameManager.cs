using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool canMove = false;
    public bool StageClear = false;
    public bool gameOver= false;
    float timeStop;

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
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        CountTime();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            finishGame();
        }
    }

    public void GameStart() {
        canMove = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    void finishGame()
    {
        StageClear = true;
        UImanager.instance.ShowWinningScreen();
    }

    void CountTime()
    {
        timeStop = Mathf.Round(Time.time * 100f) / 100f;
        UImanager.instance.printTime(timeStop);
        if (gameOver || StageClear)
        {
            Time.timeScale = 0f;
        }
    }
}
