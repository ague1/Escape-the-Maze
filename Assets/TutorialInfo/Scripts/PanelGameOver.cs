using System;
using UnityEngine;
using UnityEngine.Rendering;

public class PanelGameOver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        gameObject.SetActive(true);  
    }
    public void Hide()
    {
        gameObject.SetActive(false);
        
    }
}
