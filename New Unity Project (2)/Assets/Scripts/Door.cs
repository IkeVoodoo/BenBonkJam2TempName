using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GenTest gen;
    public GameObject door1, door2, door3;

    private enum DoorType
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    };

    [SerializeField] private DoorType doorType;
    
    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log(collision.collider.name);
        if(collision.gameObject.tag == "Player")
        {
            GameObject player;
            if (collision.gameObject.name.Equals("PlayerHolder")) player = collision.gameObject;
            else player = GameObject.FindGameObjectWithTag("Player");
            switch (doorType)
            {
                case DoorType.UP:
                    gen.generateWithIncrement(1);
                    break;
                case DoorType.DOWN:
                    gen.generateWithIncrement(3);
                    break;
                case DoorType.LEFT:
                    gen.generateWithIncrement(2);
                    break;
                case DoorType.RIGHT:
                    gen.generateWithIncrement(0);
                    break;
            }
        }
    }
}
