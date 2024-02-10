using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPos : MonoBehaviour
{
    public GameObject targetGameObject; // the GameObject you want to keep the position of
    private Vector3 targetPosition; // the position of the target GameObject
 

    void Start()
    {

    }

    void Update()
    {
        targetPosition = targetGameObject.transform.position;
        StoragePosi();
    }

    public void StoragePosi()
    {
        if (targetPosition == null)
            return;
        transform.position = targetPosition;
    }
}
