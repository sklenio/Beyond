using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public float delayTime = 10f; // Delay time for playing the first audio, default value is 10 seconds
    public AudioSource audioSource1; // Reference to the first AudioSource component
    public bool audio1Played = false; // Flag to track if the first audio has been played
    public AudioSource audioSource2; // Reference to the second AudioSource component
    public bool audio2Played = false; // Flag to track if the second audio has been played

    private bool isAudio1Playing = false; // Flag to track if the first audio is playing

    void Start()
    {
        PlayAudio1();
    }

    public void PlayAudio1()
    {
        if (audioSource1 != null && !audio1Played) // Check if audio1 has not been played
        {
            audioSource1.PlayDelayed(delayTime); // Play the first audio with the specified delay
            isAudio1Playing = true;
            audio1Played = true; // Set flag to true when audio1 is played
            Debug.Log("AudioTrigger.cs: Audio 1 is playing with a delay");
        }
        else
        {
            Debug.LogWarning("AudioTrigger.cs: AudioSource1 is not set or audio1 has already been played");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (isAudio1Playing)
        {
            StopAudio1(); // Stop the first audio if it's already playing
            PlayAudio2();
        }
    }

    public void StopAudio1()
    {
        if (audioSource1 != null && audioSource1.isPlaying)
        {
            audioSource1.Stop(); // Stop the first audio if it's playing
            isAudio1Playing = false;
            Debug.Log("AudioTrigger.cs: Audio 1 is stopped");
        }
    }

    public void PlayAudio2()
    {
        if (audioSource2 != null && !audio2Played) // Check if audio2 has not been played
        {
            audioSource2.Play();
            audio2Played = true; // Set flag to true when audio2 is played
            Debug.Log("AudioTrigger.cs: Audio 2 is playing");
        }
        else
        {
            Debug.LogWarning("AudioTrigger.cs: AudioSource2 is not set or audio2 has already been played");
        }
    }
}