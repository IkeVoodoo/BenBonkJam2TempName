using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "Player/Data", order = 1)]
public class PlayerData : ScriptableObject
{
    public float X;
    public float Y;
    public Vector3 lastPos;
}
