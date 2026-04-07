using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunFire : MonoBehaviour
{
    // I want to make game objects to call switching between fire sprite and neutral sprite
    public GameObject gNeut;
    public GameObject gFire;
    public GameObject cNeut;
    public GameObject cFire;
    public GameObject mFire;
    public GameObject pulse;
    public GameObject charge;
    public float meleeTargetTime = 0.5f;
    public bool meleeActive = false;
    public float pulseTargetTime = 3f;

    public void Gunny(InputAction.CallbackContext context)
    {
        if (context.started) // Check for if the input action "started" (or if you clicked)
        {
            if (meleeActive == false)
            {
                gNeut.SetActive(false);
                gFire.SetActive(true);
            }
        }

        if (context.canceled) // Check for button released
        {
            if (meleeActive == false)
            {
                gNeut.SetActive(true);
                gFire.SetActive(false);
            }
        }
        // This is only for setting up sprites. Other gameplay logic will come later
    }
    public void ChaCha(InputAction.CallbackContext context)
    {
        if (context.started) // Check for if the input action "started" (or if you clicked)
        {
            if (meleeActive == false)
            {
                cNeut.SetActive(false);
                cFire.SetActive(true);
            }
        }

        if (context.canceled) // Check for button released
        {
            if (meleeActive == false)
            {
                cNeut.SetActive(true);
                cFire.SetActive(false);
            }
        }
    }

    // Mostly taking from video 10.3 Waiting for a Time

    IEnumerator MeleeTimer()
    {
        mFire.SetActive(true);
        gNeut.SetActive(false);
        gFire.SetActive(false);
        cNeut.SetActive(false);
        cFire.SetActive(false);
        meleeActive = true;

        yield return new WaitForSeconds(meleeTargetTime);
        // When yield return is done, these will run
        mFire.SetActive(false);
        gNeut.SetActive(true);
        cNeut.SetActive(true);
        meleeActive = false;
    }
    // Idea to add boolean from ChatGPT. Code written by me

    public void Melee(InputAction.CallbackContext context)
    {
        if (context.started) // Check for if the input action "started" (or if you pressed F)
        {
            StartCoroutine(MeleeTimer());
        }
    }

    IEnumerator PulseTimer()
    {
        pulse.SetActive(true);
        yield return new WaitForSeconds(pulseTargetTime);
        // When yield return is done, this will run
        pulse.SetActive(false);
    }
    // Idea to add boolean from ChatGPT. Code written by me

    public void Pulse(InputAction.CallbackContext context)
    {
        if (context.started) // Check for if the input action "started" (or if you pressed F)
        {
            StartCoroutine(PulseTimer());
        }
    }
}