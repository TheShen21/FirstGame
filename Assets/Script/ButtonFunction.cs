using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{


    public void Restart()
    {
        SceneManager.LoadScene("Level 1");
    }

   public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
