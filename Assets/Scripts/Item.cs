using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Hackathon2023/New Item", order = 0)]

public class Item : ScriptableObject
{
    public AudioClip item_sound;
    public int value;
}
