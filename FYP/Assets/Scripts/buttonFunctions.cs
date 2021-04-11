using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour
{
    
    public void onStartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void onExitGame()
    {

        Application.Quit();
    }
    public void goToMultiplayer()
    {

        SceneManager.LoadScene("MultiplayerMenu");
    }
}
