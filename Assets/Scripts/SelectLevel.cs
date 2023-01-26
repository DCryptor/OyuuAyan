using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectLevel : MonoBehaviour
{
    public void MenuLevelSelect()
    {
        SceneManager.LoadScene("Menu_2");
    }
    public void Level_1()
    {
        SceneManager.LoadScene("Scene_0");
    }
}
