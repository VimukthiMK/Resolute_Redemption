using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string gameSceneName = "GameScene"; // Replace with the name of your game scene

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("OptionsScene"); // Replace with the name of your options scene
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Add this method to be called when the player interacts with the collider
    public void LoadNextScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }

}
