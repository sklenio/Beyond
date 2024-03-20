using UnityEngine;

public class DelayedAudioPlay : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip audioClip; // The audio clip to be played
    public float delayInSeconds = 10f; // Delay in seconds before playing the audio

    private void Start()
    {
        Invoke("PlayAudioWithDelay", delayInSeconds);
    }

    private void PlayAudioWithDelay()
    {
        if (audioSource != null && audioClip != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("DelayedAudioPlay.cs: AudioSource or AudioClip is not set in the DelayedAudioPlay script.");
        }
    }
}