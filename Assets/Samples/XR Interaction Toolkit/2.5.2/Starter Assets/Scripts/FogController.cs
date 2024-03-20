using UnityEngine;
using UnityEngine.UI;

public class FogController : MonoBehaviour
{
    public Toggle toggleButton;

    private void Start()
    {
        toggleButton.onValueChanged.AddListener(OnToggleChanged);
    }

    private void OnToggleChanged(bool isOn)
    {
        RenderSettings.fog = isOn; // Enable or disable fog based on the toggle state
        if (isOn)
        {
            RenderSettings.fogColor = Color.yellow; // Set the fog color when the toggle is on
            RenderSettings.fogDensity = 0.1f; // Set the fog density when the toggle is on
        }
        else
        {
            RenderSettings.fogColor = Color.clear; // Set the fog color to clear when the toggle is off
            RenderSettings.fogDensity = 0f; // Set the fog density to 0 when the toggle is off
            


        }
    }
}