/*
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
*/

using UnityEngine;

public class DelayedAudioPlay : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip audioClip; // The audio clip to be played
    public float delayInSeconds = 10f; // Delay in seconds before playing the audio
    private bool triggerActivated = false; // Flag to check if trigger is activated

    private void Start()
    {
        // Check if trigger is not activated before invoking the delayed audio play
        if (!triggerActivated)
        {
            Invoke("PlayAudioWithDelay", delayInSeconds);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerActivated = true; // Set the trigger activation flag to true
    }

    private void PlayAudioWithDelay()
    {
        // Check if trigger is not activated before playing the audio
        if (!triggerActivated && audioSource != null && audioClip != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
        else if (triggerActivated)
        {
            Debug.Log("Trigger activated. Audio not played.");
        }
        else
        {
            Debug.LogWarning("DelayedAudioPlay.cs: AudioSource or AudioClip is not set in the DelayedAudioPlay script.");
        }
    }
}