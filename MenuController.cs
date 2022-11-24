using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string _newLevel;
    
    public void GameStart()
    {
        SceneManager.LoadScene(_newLevel);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
