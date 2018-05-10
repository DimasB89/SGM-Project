using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewOrbit : MonoBehaviour {

    [SerializeField] private Transform center;
    [SerializeField] private Vector3 axis = Vector3.up;
    [SerializeField] private float radius = 2.0f;
    [SerializeField] private float radiusSpeed = 0.5f;
    [SerializeField] private float rotationSpeed = 80.0f;

    // Use this for initialization
    void Start () {

        transform.position = (transform.position - center.position).normalized * radius + center.position;
	}
	
	// Update is called once per frame
	void Update () {

        transform.RotateAround(center.position, axis, rotationSpeed * Time.deltaTime);
        Vector3 desiredPosition = (transform.position - center.position).normalized * radius + center.position;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);

	}
}
