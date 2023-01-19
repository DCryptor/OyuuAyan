using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPoint : MonoBehaviour
{
    public CharacterManager.CutScene scene;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Actions action = other.GetComponent<Actions>();
            CharacterManager characterManager = other.GetComponent<CharacterManager>();
            action.Move_Off();
            characterManager.ActiveCutScene = scene;
        }
    }
}
