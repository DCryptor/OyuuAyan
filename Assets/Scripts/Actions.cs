using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class Actions : MonoBehaviour
{
    public GameObject[] button;
    public GameObject panel_animals;

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
        SceneManager.LoadScene("Scene_Backpack");
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
    public void Level_3()
    {
        SceneManager.LoadScene("Scene_3");
    }
    public void Level_4()
    {
        SceneManager.LoadScene("Scene_4");
    }
    public void Unhide_Animals()
    {
        panel_animals.SetActive(true);
    }
    public void Hide_Animals()
    {
        panel_animals.SetActive(false);
    }

    public void GribDestroy()
    {
        GameObject Grib = GameObject.FindGameObjectWithTag("Grib");
        Destroy(Grib);
    }
    public void RabbitActivation()
    {
        GameObject rabbit = GameObject.FindGameObjectWithTag("Rabbit");
        rabbit.GetComponent<Rabbyt>().RabbytAnimation();
    }
    public void MostActivation()
    {
        GameObject most = GameObject.FindGameObjectWithTag("Most");
        most.GetComponent<Most>().MostAnimation();
    }
    public void Final_Level()
    {
        SceneManager.LoadScene("Scene_5");
    }

    public void TheEnd()
    {
        SceneManager.LoadScene("Final");
    }

}
