using UnityEngine;
using TMPro;

public class AudioMenu : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;
    public TMP_Text play;

    void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
        play.text = "Play";
    }

    public void PlayAudio()
    {
        myAudioSource.Play();
    }

    public void PauseAudio()
    {
        myAudioSource.Pause();
    }

    public void AudioStop()
    {
        myAudioSource.Stop();
    }

    public void PlayAndStop()
    {
        if (Input.GetMouseButton(0))
        {
            PlayAudio();
        } else if (Input.GetMouseButton(0))
        {
            AudioStop();
        }
    }
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            play.SetText("Stop");
        }
    }
}