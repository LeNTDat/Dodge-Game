using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") {
            ScoreManager.instance.DecrementScore();
            transform.GetComponent<Renderer>().material.color = Color.red;
            if(ScoreManager.instance.score == 0)
            {
                GameManager.Instance.gameOver = true;
                UImanager.instance.ShowGameOverScreen();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            transform.GetComponent<Renderer>().material.color = Color.white;
        }
    }


}
