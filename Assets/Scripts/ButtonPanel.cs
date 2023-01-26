using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonPanel : MonoBehaviour
{
    public void ButtonOn()
    {
        this.gameObject.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu_2");
    }
}
