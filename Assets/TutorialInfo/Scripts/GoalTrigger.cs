using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audioClip;
    public ParticleSystem confettiEffect;
    [SerializeField] private TimerTrigger timer;
    public PanelRanking panelRanking;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            timer.StopTimer();
            confettiEffect.Play();
            audioSource.PlayOneShot(audioClip,1.0f);
            timer.clock.Stop();
            panelRanking.Show();
        }
    }
}
