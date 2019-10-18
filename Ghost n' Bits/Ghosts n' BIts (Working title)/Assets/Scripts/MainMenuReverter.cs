using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuReverter : MonoBehaviour
{
    public void StartGame(string Menu)
    {
        SceneManager.LoadScene("Menu");
    }
}    
        