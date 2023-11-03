using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMove : MonoBehaviour
{
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}