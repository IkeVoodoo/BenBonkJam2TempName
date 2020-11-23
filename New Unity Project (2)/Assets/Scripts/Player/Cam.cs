using UnityEngine;

public class Cam : MonoBehaviour
{
    // Offset
    public Vector3 offset;

    void Update()
    {
        // Get the room
        GameObject plane = GameObject.FindWithTag("Room");

        // Move the camera to pos of room + offset
        transform.position = plane.transform.position + offset;

        // Look at room
        transform.LookAt(plane.transform);
    }
}
