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

    private void Start()
    {
        m_currentTime = 0;
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        m_currentTime += Time.deltaTime;
        var percentTime = m_currentTime / timeToTake;
        var newPos = BeizeirCurve.QuadraticLerp(_player.FirePoint.position, _player.Power.position, _player.End.position, percentTime);
        paper.position = newPos;

        if (Vector3.Distance(paper.transform.position, _player.End.position) < 0.1f)
        {
            Destroy(gameObject, 5f);
            Debug.Log("Reached the end");
        }
    }

    public void SetDirection(Vector3 dir)
    {
        direction = dir;
    }

}
