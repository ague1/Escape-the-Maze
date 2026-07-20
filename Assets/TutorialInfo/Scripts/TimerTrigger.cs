using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimerTrigger : MonoBehaviour
{
    public Text timeText;
    private float elapsedTime;
    private float maxTime= 30f;
    private bool isRunning;

    public PanelGameOver panelGameOver;

    public GameObject player;

    public AudioSource clock;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        elapsedTime = 0f;
        clock.Play();
        isRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRunning) return;

        elapsedTime += Time.deltaTime;
        timeText.text =  Mathf.Ceil(elapsedTime).ToSafeString() + "s";
            
        if (elapsedTime >= maxTime)
        {
            panelGameOver.Show();
            player.GetComponent<PlayerController>().enabled = false;
            clock.Stop();
            StopTimer();
        }

    }

    public void StopTimer()
    {
        isRunning =  false;
    }

    public float GetElapsedTime()
    {
        return elapsedTime;
    }
}
