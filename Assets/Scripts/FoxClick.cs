using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxClick : MonoBehaviour
{
    public GameObject grib;
    public CharacterManager characterManager;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider.tag == "Fox")
            {
                grib.SetActive(true);
                characterManager.ActiveCutScene = CharacterManager.CutScene.final_4;
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
