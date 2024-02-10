using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
        }

        
    }

    void Toss()
    {
      
        GameObject PaperClone = Instantiate(paper, FirePoint.position, Quaternion.identity);
        BulletPreview.SetActive(false);
        UpdateArcPos();
        Paper ball = PaperClone.GetComponent<Paper>();
        ball.SetDirection(transform.forward);
        StartCoroutine(CoolDown());
    }

    IEnumerator CoolDown()
    {
        ReadyToShoot = false;
        yield return new WaitForSeconds(1f);
        BulletPreview.SetActive(true);
        Debug.Log("Bullet Ready");
        ReadyToShoot = true;
    }

    void UpdateArcPos()
    {
        Vector3 ThisXPos = Power.position;
        ThisXPos.x = transform.position.x;
        Power.position = ThisXPos;
    }





}

