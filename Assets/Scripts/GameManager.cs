using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool canMove = false;
    public bool isStart = false;
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
        countTime();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Done");
        }
    }

    void GameStart() {
        canMove = true;
    }

    void countTime () {
        if (isStart)
        {
            print(Mathf.Round(Time.time * 100f) / 100f);
        }

    }

}
