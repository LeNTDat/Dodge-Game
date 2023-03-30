using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpDownObject : MonoBehaviour
{

    float speed = 16f;
    bool stop = false;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("StartCourotine", 1.0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartCourotine()
    {
        StartCoroutine("showTime");
    }

    private IEnumerator showTime() { 
        yield return new WaitForSeconds(2.0f);
        rb.velocity = new Vector3(0, 3, 0);
        rb.useGravity = true;
        yield return new WaitForSeconds(2.0f);
        rb.useGravity = false;
        rb.velocity = new Vector3(0, 10, 0);
        yield return null;
    }

}
