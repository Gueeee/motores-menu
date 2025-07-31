using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenuScript : MonoBehaviour
{
    public EventSystem myInputField;

    #region Métodos dos botões
    public void MainMenu()
    {
        Invoke("gotoMenu", 2f);
    }

    public void PlayGame()
    {
        Invoke("gotoGame", 2f);
    }

    public void PassWord()
    {
        Invoke("gotoPassWord", 2f);
    }

    public void OptionsMode()
    {
        Invoke("gotoOptions", 2f);
    }

    #endregion

    #region Métodos que são chamados com Delay
    void gotoPassWord()
    {
        SceneManager.LoadSceneAsync(2);
    }
    void gotoMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    void gotoGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    void gotoOptions()
    {
        SceneManager.LoadSceneAsync(3);
    }

    #endregion
    
    void Update() {
        if (Input.GetKey(KeyCode.Return))
        {
            myInputField.enabled = false;
        }
    }
}
