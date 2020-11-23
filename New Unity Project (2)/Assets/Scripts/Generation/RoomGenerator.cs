using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    // Player reference
    public Player player;

    // name
    public GameObject roomPrefab;

    // Character controller
    public CharacterController cc;


    public GameObject genAtPos(float X, float Y)
    {
        roomPrefab = GameObject.FindWithTag("Room");
        GameObject obj = Instantiate(roomPrefab, new Vector3(X * 10, 0f, Y * 10), Quaternion.identity);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = new Vector3(player.transform.position.x + (X * 10), 1, player.transform.position.y + (Y * 10));
        cc.enabled = true;

        return obj;
    }


    public GameObject generateLeft()
    {
        roomPrefab = GameObject.FindWithTag("Room");
        GameObject obj = Instantiate(roomPrefab, new Vector3(transform.position.x - 10, 0f, transform.position.y), Quaternion.identity);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = obj.transform.position + new Vector3(3f, 0, 0);
        cc.enabled = true;

        return obj;
    }

    public GameObject generateRight()
    {
        roomPrefab = GameObject.FindWithTag("Room");
        GameObject obj = Instantiate(roomPrefab, new Vector3(transform.position.x + 10, 0f, transform.position.y), Quaternion.identity);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = obj.transform.position - new Vector3(3f, 0, 0);
        cc.enabled = true;

        return obj;
    }

    public GameObject generateUp()
    {
        roomPrefab = GameObject.FindWithTag("Room");
        GameObject obj = Instantiate(roomPrefab, new Vector3(transform.position.x, 0f, transform.position.z + 10), Quaternion.identity);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = obj.transform.position - new Vector3(0, 0, 3f);
        cc.enabled = true;

        return obj;
    }

    public GameObject generateDown()
    {
        roomPrefab = GameObject.FindWithTag("Room");
        GameObject obj = Instantiate(roomPrefab, new Vector3(transform.position.x, 0f, transform.position.y - 10), Quaternion.identity);
        obj.SetActive(true);
        cc.enabled = false;
        player.transform.position = new Vector3(player.transform.position.x, 1, player.transform.position.z - 10);
        cc.enabled = true;

        return obj;
    }
}
