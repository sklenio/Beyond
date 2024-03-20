using UnityEngine;
using UnityEngine.UI;

public class SetActiveButton : MonoBehaviour
{
    public GameObject objectToToggle;
    private bool isActive = false;

    public void ToggleObject()
    {
        isActive = !isActive; // Update the boolean value
        objectToToggle.SetActive(isActive);
    }
}