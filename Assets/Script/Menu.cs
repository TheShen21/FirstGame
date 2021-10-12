using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
        ScoreScript.scoreValue = 0;

    }
    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
        ScoreScript.scoreValue = 0;
    }
    public void EndGame()
    {
        Application.Quit();
    }

}
