using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public PlayerData data;
    public RoomGenerator gen;

    private float updateTimer = .5f;
    private bool updated = false;

    public void Update()
    {
        if (updateTimer <= 0f && !updated)
        {
            Destroy(GameObject.FindWithTag("Room"));
            gen.genAtPos(data.X, data.Y);
            updated = true;
        }
        else updateTimer -= Time.deltaTime;
    }
}
