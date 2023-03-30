using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBlock : MonoBehaviour
{

    int RotationDirect;
    // Start is called before the first frame update
    void Start()
    {
        RotationDirect = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        RotationCheck();
    }

    void RotationCheck()
    {
        if(RotationDirect > 0)
        {
            transform.Rotate(0, 0.5f, 0); 
        }else if(RotationDirect <= 0)
        {
            transform.Rotate(0, -0.5f, 0);
        }

    }
}
