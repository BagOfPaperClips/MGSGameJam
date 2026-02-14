using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void TitleScreen()
    {
        SceneManager.LoadScene("Title");
    }
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
    public void Help()
    {
        SceneManager.LoadScene("Help");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void EndScreen()
    {
        SceneManager.LoadScene("EndScreen");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
