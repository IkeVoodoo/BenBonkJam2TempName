using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public PlayerData data;
    public RoomGenerator gen;

    [Header("UI")]
    public TMP_Text coordDisplay;

    [Header("Movement")]
    public float speed = 5f;

    private CharacterController cc;

    private void Start()
    {
        // Character controller
        cc = GetComponent<CharacterController>();
        
        // Get the room
        GameObject currFloor = GameObject.FindWithTag("Room");

        // Generate new room
        GameObject obj = currFloor.GetComponent<RoomGenerator>().genAtPos(data.X, data.Y);
        Destroy(currFloor);
        obj.name = "Room";
        gen = obj.GetComponent<RoomGenerator>();
        gen.player = this;

        // Reset position to last position
        transform.position = data.lastPos;
        
    }

    void Update()
    {
        // Get the new generator
        if (gen == null)
        {
            gen = GameObject.FindWithTag("Room").GetComponent<RoomGenerator>();
            gen.player = this;
        }
        

        // Update coords
        coordDisplay.SetText("(" + data.X + ", " + data.Y + ")");


        // Update position
        data.lastPos = transform.position;

        movement();
    }

    private void movement()
    {
        cc.Move(new Vector3((Input.GetAxis("Horizontal") * speed) * Time.deltaTime, 0f, (Input.GetAxis("Vertical") * speed) * Time.deltaTime));
    }
}
