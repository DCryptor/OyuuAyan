using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Actions : MonoBehaviour
{
    public GameObject[] button;
    public bool isMove;
    public void Hide_Buttons()
    {
        button[0].SetActive(false);
        button[1].SetActive(false);
    }
    public void Unhide_Buttons()
    {
        button[0].SetActive(true);
        button[1].SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Scene_1");
    }

    public void Move_On()
    {
        isMove = true;
    }
    public void Move_Off()
    {
        isMove = false;
    }

    public void GriAnimation()
    {
        GameObject Grib = GameObject.FindGameObjectWithTag("Grib");
        Grib.GetComponent<Animator>().SetTrigger("Grib");
    }

    public void Level_2()
    {
        SceneManager.LoadScene("Scene_2");
    }

    public void ButtonCreate()
    {

    }
}
