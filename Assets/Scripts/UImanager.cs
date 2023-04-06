using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Text timeCount;
    public GameObject LosingPanel;
    public GameObject WiningPanel;
    public GameObject MenuPanel;
    public GameObject TapStartPanel;





    public static UImanager instance;   
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void ShowMenuStartGame()
    {
        if (GameManager.Instance.isStart)
        {
            MenuPanel.SetActive(false);
            TapStartPanel.SetActive(false);
        }
    }

    public void ShowGameOverScreen ()
    {
        LosingPanel.SetActive(true);
    }

    public void ShowWinningScreen () {
        WiningPanel.SetActive(true);
    }

    public void printTime(float time)
    {
        timeCount.text = time.ToString();
    }
}
