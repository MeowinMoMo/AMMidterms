using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public float speed;
    public float maxYPosition;
    public float minYPosition;

    private bool movingUp = true;

    void Update()
    {
        if (movingUp)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);

            if (transform.position.y > maxYPosition)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);

            if (transform.position.y < minYPosition)
            {
                movingUp = true;
            }
        }
    }
}
