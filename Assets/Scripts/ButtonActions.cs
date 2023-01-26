using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public CharacterManager characterManager;
    private UIPanel panel;
    public GameObject grib_za_besom;
    public GameObject grib_za_elkoy;
    public GameObject grib_za_berezoy;

    public int value = 0;

    void Start()
    {
        panel = GetComponent<UIPanel>();
    }
    public void Bes()
    {
        value = value + 1;
        if (value <= 2)
        {
            characterManager.ActiveCutScene = CharacterManager.CutScene.net_bes;
        }
        if (value == 3)
        {
            characterManager.ActiveCutScene = CharacterManager.CutScene.za_bes;
            grib_za_besom.SetActive(true);
            panel.PanelOff();
        }
    }

    public void Elka()
    {
        value = value + 1;
        if (value <= 2)
        {
            characterManager.ActiveCutScene = CharacterManager.CutScene.net_elka;
        }
        if (value == 3)
        {
            characterManager.ActiveCutScene = CharacterManager.CutScene.za_elkoy;
            grib_za_elkoy.SetActive(true);
            panel.PanelOff();
        }
    }
    public void Bereza()
    {
        value = value + 1;
        if (value <= 2)
        {
            characterManager.ActiveCutScene = CharacterManager.CutScene.net_bereza;
        }
        if (value == 3)
        {
            characterManager.ActiveCutScene = CharacterManager.CutScene.za_bereza;
            grib_za_berezoy.SetActive(true);
            panel.PanelOff();
        }
    }
}
