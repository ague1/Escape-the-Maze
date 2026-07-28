using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System.Collections.Generic;

public class PanelRanking : MonoBehaviour
{
    public Text recordText;
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

    public void Show()
    {
        float finalTimer = timer.GetElapsedTime();
        string saveTimes = PlayerPrefs.GetString("Tiempos", "");
        var list = new List<float>();

        if (!string.IsNullOrEmpty(saveTimes))
        { 
            foreach (var t in saveTimes.Split(','))
            {
                if (float.TryParse(t, NumberStyles.Float,
                CultureInfo.InvariantCulture, out float val))
                {
                    list.Add(val);
                }
            }
        }
        
        list.Add(finalTimer);

        list.Sort();

        if (list.Count > 3)
            list.RemoveRange(3, list.Count - 3);
        
        
        PlayerPrefs.SetString("Tiempos", string.Join(",", list.ConvertAll(x => x.ToString(CultureInfo.InvariantCulture))));
        PlayerPrefs.Save();


        string texto = "Último Tiempo: " + finalTimer.ToString("F2") + "s\n";

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
