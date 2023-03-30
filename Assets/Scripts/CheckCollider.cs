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
            print(ScoreManager.instance.score);
            transform.GetComponent<Renderer>().material.color = Color.red;    
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
