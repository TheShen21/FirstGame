using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    bool gameEnded = false; 

    public void GameOver()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Over();
        }

    }
    void Over()
    {
        SceneManager.LoadScene("GameOver");
    }
}
