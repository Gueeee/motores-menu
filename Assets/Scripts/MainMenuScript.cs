using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void PlayGame() {
        SceneManager.LoadSceneAsync(1);
    }
    
    public void PassWord() {
        SceneManager.LoadSceneAsync(2);
    }
    
    public void OptionsMode() {
        SceneManager.LoadSceneAsync(3);
    }
}
