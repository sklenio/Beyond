using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSource;
    public Toggle playPauseToggle;

    private void Start()
    {
        playPauseToggle.onValueChanged.AddListener(OnToggleChanged);
    }

    private void OnToggleChanged(bool isOn)
    {
        if (isOn)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Pause();
        }
    }
}

/*
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSource;
    public Button playPauseButton;

    private bool isPlaying = false;

    private void Start()
    {
        playPauseButton.onClick.AddListener(ToggleSound);
    }

    private void ToggleSound()
    {
        if (isPlaying)
        {
            audioSource.Pause();
            isPlaying = false;
            playPauseButton.GetComponentInChildren<Text>().text = "Play";
        }
        else
        {
            audioSource.Play();
            isPlaying = true;
            playPauseButton.GetComponentInChildren<Text>().text = "Pause";
        }
    }
}
*/

/*
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSource;
    public Button playButton;
    public Button pauseButton;

    private bool isPlaying = false;

    private void Start()
    {
        playButton.onClick.AddListener(PlaySound);
        pauseButton.onClick.AddListener(PauseSound);
    }

    private void PlaySound()
    {
        if (!isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
        }
    }

    private void PauseSound()
    {
        if (isPlaying)
        {
            audioSource.Pause();
            isPlaying = false;
        }
    }
}

*/