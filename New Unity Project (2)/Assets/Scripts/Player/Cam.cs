using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Vector3 offset;

    void Update()
    {
        GameObject plane = GameObject.Find("Plane");
        transform.position = plane.transform.position + offset;
        transform.LookAt(plane.transform);
    }
}
