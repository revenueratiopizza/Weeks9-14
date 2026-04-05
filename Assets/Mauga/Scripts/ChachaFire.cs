using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class ChachaFire : MonoBehaviour
{
    // I want to make game objects to call switching between fire sprite and neutral sprite

    public GameObject cNeut;
    public GameObject cFire;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // I don't think we need anything in here right now
    }

    public void ChaCha(InputAction.CallbackContext context)
    {
        if (context.started) // Check for if the input action "started" (or if you clicked)
        {
            cNeut.SetActive(false);
            cFire.SetActive(true);
        }

        if (context.canceled) // Check for button released
        {
            cNeut.SetActive(true);
            cFire.SetActive(false);
        }
    }
    // This is only for setting up sprites. Other gameplay logic will come later
    }

