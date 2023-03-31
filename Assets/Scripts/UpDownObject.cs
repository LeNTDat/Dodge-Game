using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpDownObject : MonoBehaviour
{

    float speed = 20f;
    bool stop = false;
    Rigidbody rb;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GoingUp();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.tag);
        if(other.gameObject.tag == "Zone")
        {
            GoingUp();
        }else if(other.gameObject.tag == "GhostBlock") {
            GoingDown();
        }
    }


    private void GoingDown()
    {
        rb.velocity = new Vector3(0, -speed, 0);
    }

    private void GoingUp() { 
        rb.velocity = new Vector3(0, speed, 0);
    }

}
