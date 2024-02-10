using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
    public Transform paper;
  /*  public Transform FirePoint;
    public Transform Power;
    public Transform End;*/
    public float timeToTake;
    public float m_currentTime;
    Vector3 direction;
    Player _player;
    Power ArcPoint;
    bool hasCalled;

    //Add Projectile Speed
    int Speed = 8;

    private void Start()
    {
        m_currentTime = 0;
        _player = FindObjectOfType<Player>();
        ArcPoint = FindObjectOfType<Power>();
    }

    private void Update()
    {
        //Add Speed here
        m_currentTime += Speed *Time.deltaTime;
        var percentTime = m_currentTime / timeToTake;
        var newPos = BeizeirCurve.QuadraticLerp(_player.FirePoint.position, _player.Power.position, _player.End.position, percentTime);
        paper.position = newPos;

        if (Vector3.Distance(paper.transform.position, _player.End.position) < 0.1f && !hasCalled)
        {
            Destroy(gameObject, 5f);
            Debug.Log("Reached the end");
            hasCalled = true;
        }
    }

    public void SetDirection(Vector3 dir)
    {
        direction = dir;
    }
}
