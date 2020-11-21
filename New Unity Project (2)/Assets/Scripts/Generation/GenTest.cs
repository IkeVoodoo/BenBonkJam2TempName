using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenTest : MonoBehaviour
{

    public Player player;

    public void generate(int pos, bool increment)
    {
        GameObject currFloor = GameObject.Find("Plane");
        switch (pos)
        {
            case 0:
                GameObject objRight = currFloor.GetComponent<RoomGenerator>().generateRight();
                if( increment) player.data.X--;
                Destroy(currFloor);
                objRight.AddComponent<RoomGenerator>();
                break;
            case 1:
                GameObject objUp = currFloor.GetComponent<RoomGenerator>().generateUp();
                if (increment)  player.data.Y++;
                Destroy(currFloor);
                objUp.AddComponent<RoomGenerator>();
                break;
            case 2:
                GameObject objLeft = currFloor.GetComponent<RoomGenerator>().generateLeft();
                if (increment)  player.data.X++;
                Destroy(currFloor);
                objLeft.AddComponent<RoomGenerator>();
                break;
            case 3:
                GameObject objDown = currFloor.GetComponent<RoomGenerator>().generateDown();
                if (increment) player.data.Y--;
                Destroy(currFloor);
                objDown.AddComponent<RoomGenerator>();
                break;
        }
    }

    public void generate(int pos)
    {
        GameObject currFloor = GameObject.Find("Plane");
        switch (pos)
        {
            case 0:
                GameObject objRight = currFloor.GetComponent<RoomGenerator>().generateRight();
                player.data.X++;
                Destroy(currFloor);
                objRight.AddComponent<RoomGenerator>();
                objRight.GetComponent<RoomGenerator>().player = player;
                break;
            case 1:
                GameObject objUp = currFloor.GetComponent<RoomGenerator>().generateUp();
                player.data.Y++;
                Destroy(currFloor);
                objUp.AddComponent<RoomGenerator>();
                objUp.GetComponent<RoomGenerator>().player = player;
                break;
            case 2:
                GameObject objLeft = currFloor.GetComponent<RoomGenerator>().generateLeft();
                player.data.X--;
                Destroy(currFloor);
                objLeft.AddComponent<RoomGenerator>();
                objLeft.GetComponent<RoomGenerator>().player = player;
                break;
            case 3:
                GameObject objDown = currFloor.GetComponent<RoomGenerator>().generateDown();
                player.data.Y--;
                Destroy(currFloor);
                objDown.AddComponent<RoomGenerator>();
                objDown.GetComponent<RoomGenerator>().player = player;
                break;
        }
    }

}
