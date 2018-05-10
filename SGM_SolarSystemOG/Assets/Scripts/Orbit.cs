using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {


    public Transform target;
    [Range(1, 100)]
    public float speed;
    [Range(0, 5)]
    public float distance;

    void Update()
    {
        Vector3 relativePos = (target.position - transform.position);
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime * distance);
        transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
