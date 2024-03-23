using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public Toggle toggleButton;

    private void Start()
    {
        toggleButton.onValueChanged.AddListener(OnToggleChanged);
    }

    private void OnToggleChanged(bool isOn)
    {
        if (isOn)
        {
            SetIntensityOff();
        }
        else
        {

            SetIntensityOn();
        }
    }

    public void SetIntensityOn()
    {
            RenderSettings.ambientIntensity = 1.0f; // Set the desired ambient intensity when the toggle is on
            RenderSettings.sun.intensity = 1.0f; // Set the sun's intensity when the toggle is on
    }

    public void SetIntensityOff()
    {
            RenderSettings.ambientIntensity = 0.0f; // Set the ambient intensity to 0 to turn off the light when the toggle is off
            RenderSettings.sun.intensity = 0.0f; // Set the sun's intensity to 0 to turn off the light when the toggle is off
    }
}