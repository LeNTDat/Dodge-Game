using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if (GameManager.Instance.canMove)
        {
            float InputX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            float InputZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

            transform.Translate(InputX, 0 , InputZ);
        }
    }

}
