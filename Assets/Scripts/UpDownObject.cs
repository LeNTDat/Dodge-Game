using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpDownObject : MonoBehaviour
{

    float speed = 20f;
    bool stop;
    Rigidbody rb;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Zone")
        {
            GoingUp();
        }
        else if (other.gameObject.tag == "GhostBlock")
        {
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
