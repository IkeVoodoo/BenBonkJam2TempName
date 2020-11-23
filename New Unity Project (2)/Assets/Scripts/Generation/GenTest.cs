using UnityEngine;
using GameJamUtils.GameObjectUtils;

public class GenTest : MonoBehaviour
{

    public Player player;
    public GameObject roomPrefab;

    public void generate(int pos)
    {
        GameObject currFloor = GameObject.FindWithTag("Room");
        switch (pos)
        {
            case 0:
                GameObject objRight = currFloor.GetComponent<RoomGenerator>().generateRight();
                setup(objRight);
                Destroy(currFloor);
                break;
            case 1:
                GameObject objUp = currFloor.GetComponent<RoomGenerator>().generateUp();
                setup(objUp);
                Destroy(currFloor);
                break;
            case 2:
                GameObject objLeft = currFloor.GetComponent<RoomGenerator>().generateLeft();
                setup(objLeft);
                Destroy(currFloor);
                break;
            case 3:
                GameObject objDown = currFloor.GetComponent<RoomGenerator>().generateDown();
                setup(objDown);
                Destroy(currFloor);
                break;
        }
    }
    public void generateWithIncrement(int pos)
    {

        GameObject currFloor = GameObject.FindWithTag("Room");
        switch (pos)
        {
            case 0:
                GameObject objRight = currFloor.GetComponent<RoomGenerator>().generateRight();
                player.data.X++;
                setup(objRight);
                Destroy(currFloor);
                break;
            case 1:
                GameObject objUp = currFloor.GetComponent<RoomGenerator>().generateUp();
                player.data.Y++;
                setup(objUp);
                Destroy(currFloor);
                break;
            case 2:
                GameObject objLeft = currFloor.GetComponent<RoomGenerator>().generateLeft();
                player.data.X--;
                setup(objLeft);
                Destroy(currFloor);
                break;
            case 3:
                GameObject objDown = currFloor.GetComponent<RoomGenerator>().generateDown();
                player.data.Y--;
                setup(objDown);
                Destroy(currFloor);
                break;
        }

        //GetComponent<AudioSource>().Play();
    }

    private GameObject setup(GameObject obj)
    {
        GameObject currFloor = GameObject.FindWithTag("Room");
        RoomGenerator gen = obj.GetComponent<RoomGenerator>();

        gen.player = player;
        if(roomPrefab == null) roomPrefab = currFloor;
        gen.roomPrefab = currFloor;
        player.gen = gen;
        obj.name = "Room";

        if (GameObjectUtils.distance(currFloor, player.gameObject) > 10)
            player.gameObject.transform.position = currFloor.transform.position + new Vector3(0, 1, 0);
        else if (GameObjectUtils.distance(currFloor, player.gameObject) < -10)
            player.gameObject.transform.position = currFloor.transform.position + new Vector3(0, 1, 0);

        return obj;
    }

}
