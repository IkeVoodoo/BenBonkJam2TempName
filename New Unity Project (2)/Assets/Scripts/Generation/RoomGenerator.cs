using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    public Player player;

    private CharacterController cc;

    private void Start()
    {
        cc = player.GetComponent<CharacterController>();
    }

    public GameObject genAtPos(float X, float Y)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Plane);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = new Vector3(player.transform.position.x + (X * 10), 1, player.transform.position.y + (Y * 10));
        cc.enabled = true;
        obj.transform.position = new Vector3(X * 10, 0, Y * 10);
        return obj;
    }

    public GameObject generateLeft()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Plane);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = new Vector3(player.transform.position.x - 10, 1, player.transform.position.z);
        cc.enabled = true;
        obj.transform.position = new Vector3(transform.position.x - 10, 0, transform.position.z);
        return obj;
    }

    public GameObject generateRight()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Plane);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = new Vector3(player.transform.position.x + 10, 1, player.transform.position.z);
        cc.enabled = true;
        obj.transform.position = new Vector3(transform.position.x + 10, 0, transform.position.z);
        return obj;
    }

    public GameObject generateUp()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Plane);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = new Vector3(player.transform.position.x, 1, player.transform.position.z + 10);
        cc.enabled = true;
        obj.transform.position = new Vector3(transform.position.x, 0, transform.position.z + 10);
        return obj;
    }

    public GameObject generateDown()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Plane);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = new Vector3(player.transform.position.x, 1, player.transform.position.z - 10);
        cc.enabled = true;
        obj.transform.position = new Vector3(transform.position.x, 0, transform.position.z - 10);
        return obj;
    }
}
