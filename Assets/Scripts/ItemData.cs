using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    public CharacterManager.CutScene scene;
    public Item item;
    [HideInInspector] public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
}
