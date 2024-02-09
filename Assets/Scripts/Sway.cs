using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sway : MonoBehaviour
{
    public float speed;
    public float maxXPosition;
    public float minXPosition;

    private bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

            if (transform.position.x > maxXPosition)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);

            if (transform.position.x < minXPosition)
            {
                movingRight = true;
            }
        }
    }
}
