using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    public void PanelOn()
    {
        this.gameObject.SetActive(true);
    }
    public void PanelOff()
    {
        this.gameObject.SetActive(false);
    }
}
