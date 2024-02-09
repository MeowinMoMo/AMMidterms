using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*    public float tossForce; // Force applied to the paper
        public float tossAngle;   // Angle applied to the force*/

    public GameObject paper;
    public Transform FirePoint;
    public Transform Power;
    public Transform End;

    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Toss();
        }
    }

    void Toss()
    {
        GameObject PaperClone = Instantiate(paper, FirePoint.transform.position, Quaternion.identity);
        Paper ball = PaperClone.GetComponent<Paper>();
        ball.SetDirection(transform.forward);
    }

   

}

