using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFunction : MonoBehaviour
{
    private Transform centerpoint;
    public float rotationSpeed;
    void Start()
    {
        centerpoint = GetComponent<Transform>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotationSpeed *= -1f;
        }

        centerpoint.Rotate(0f, 0f, -rotationSpeed, Space.Self);
    }
}
