using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*    public float tossForce; // Force applied to the paper
        public float tossAngle;   // Angle applied to the force*/

    public GameObject paper;
    public GameObject BulletPreview;
    public Transform FirePoint;
    public Transform Direction;
    public Transform Power;
    public Transform End;
    FirstPos firepos;
    bool ReadyToShoot;
    private void Start()
    {
        ReadyToShoot = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ReadyToShoot)
        {
            Toss();

            //No need for this since you're not telling which GameObject you're accessing in the scene, so it returns error instance
            //firepos.StoragePosi();
        }

        
    }

    void Toss()
    {
        /*GetStoredPosition();*/
        GameObject PaperClone = Instantiate(paper, FirePoint.position, Quaternion.identity);
        BulletPreview.SetActive(false);
        UpdateArcPos();
        Paper ball = PaperClone.GetComponent<Paper>();
        ball.SetDirection(transform.forward);
        StartCoroutine(CoolDown());
    }

    IEnumerator CoolDown()
    {
        //Wait for 1 Second then fire this shit
        ReadyToShoot = false;
        yield return new WaitForSeconds(1f);
        BulletPreview.SetActive(true);
        Debug.Log("Bullet Ready");
        ReadyToShoot = true;
    }

    void UpdateArcPos()
    {
        //Create An empty vector 3 then get the arc pos, then horizontal pos of player, then its X pos will now be from player.

        Vector3 ThisXPos = Power.position;
        ThisXPos.x = transform.position.x;
        Power.position = ThisXPos;
    }





}

