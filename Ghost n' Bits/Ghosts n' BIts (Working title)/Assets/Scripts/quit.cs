using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour
{
    public void doquit()
    {
        Debug.Log("Game is exiting");
        Application.Quit();
    }
}