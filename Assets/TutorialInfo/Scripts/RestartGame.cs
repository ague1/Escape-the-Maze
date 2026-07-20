using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    
     public void RestartScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
