using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PanelRanking : MonoBehaviour
{
    public Text recordText;
    private float lastTime = 0f;
    [SerializeField] private TimerTrigger timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLastTime(float time)
    {
        lastTime = time;
    }

    public void Show()
    {
        float finalTimer = timer.GetElapsedTime();
        SetLastTime(finalTimer);
        string saveTimes = PlayerPrefs.GetString("Tiempos", "");
        var list = new List<float>();

        if (!string.IsNullOrEmpty(saveTimes))
        { 
            foreach (var t in saveTimes.Split(','))
            {
                if (float.TryParse(t, out float val))
                list.Add(val);
            }
        }
        
        list.Add(finalTimer);

        list.Sort();
        
        PlayerPrefs.SetString("Tiempos", string.Join(",", list));
        PlayerPrefs.Save();


        string texto = "Último Tiempo: " + lastTime.ToString("F2") + "s\n";

        for (int i = 0; i < 3; i++)
        {
            if (i < list.Count)
            texto += (i+1) + "°: " + list[i].ToString("F2") + "s\n";
            else
            texto += (i+1) + "°: -\n";
        }
        
        recordText.text = texto;
        gameObject.SetActive(true); 
    }


    
}
