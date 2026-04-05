using UnityEngine;
using UnityEngine.InputSystem;

public class GunnyFire : MonoBehaviour
{
    // I want to make game objects to call switching between fire sprite and neutral sprite

    public GameObject gNeut;
    public GameObject gFire;

    public void Gunny(InputAction.CallbackContext context)
    {
        if (context.started) // Check for if the input action "started" (or if you clicked)
        {
            gNeut.SetActive(false);
            gFire.SetActive(true);
        }

        if (context.canceled) // Check for button released
        {
            gNeut.SetActive(true);
            gFire.SetActive(false);
        }
        // This is only for setting up sprites. Other gameplay logic will come later
    }
}
