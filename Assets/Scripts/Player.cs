using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float tossForce; // Force applied to the paper
    public float tossAngle;   // Angle applied to the force

    public Transform paper;
    public Transform trashBin;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
            Toss();

        // Check if the paper is inside the trash bin
        /*if (trashBin.GetComponent<Collider2D>().bounds.Contains(paper.position))
        {
            // Destroy the paper or start success animation
            Destroy(paper.gameObject);
            // Your success animation code here
        }*/
    }

    void Toss()
    {
        float forceMagnitude = tossForce;
        float x = forceMagnitude * Mathf.Cos(tossAngle * Mathf.Deg2Rad);
        float y = forceMagnitude * Mathf.Sin(tossAngle * Mathf.Deg2Rad);
        /*float z = forceMagnitude * Mathf.Atan(tossAngle * Mathf.Deg2Rad);*/
        Vector3 force = new Vector3(x, y);

        // Apply the force to the paper
        paper.transform.position += force * Time.deltaTime;
    }
}
