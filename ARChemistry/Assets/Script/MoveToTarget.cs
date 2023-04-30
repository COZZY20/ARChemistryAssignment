using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float minDistance = 0.1f;

    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > minDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
