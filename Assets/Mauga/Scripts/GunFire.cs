using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunFire : MonoBehaviour
{
    // I want to make game objects to call switching between fire sprite and neutral sprite
    public GameObject gNeut;
    public GameObject gFire;
    public GameObject gbFire;
    public GameObject cNeut;
    public GameObject cFire;
    public GameObject cbFire;
    public GameObject mFire;
    public GameObject pulse;
    public GameObject charge;
    public float meleeTargetTime = 0.5f;
    public bool meleeActive = false;
    public float pulseTargetTime = 3f;
    public float fireDelayRate = 0.05f;
    public bool gunnyActive = false;
    public bool chachaActive = false;

    // Using an if statement here wouldn't work well since I need to check if it's active constantly
    IEnumerator GunnyBulletFire()
    {
        while (gunnyActive == true)
        {
            gbFire.SetActive(true);
            yield return new WaitForSeconds(fireDelayRate);
            gbFire.SetActive(false);
            yield return new WaitForSeconds(fireDelayRate);
        }
    }

    public void Gunny(InputAction.CallbackContext context)
    {
        if (context.started) // Check for if the input action "started" (or if you clicked)
        {
            if (meleeActive == false)
            {
                gunnyActive = true;
                gNeut.SetActive(false);
                gFire.SetActive(true);
                StartCoroutine(GunnyBulletFire());
            }
        }

        if (context.canceled) // Check for button released
        {
            if (meleeActive == false)
            {
                gunnyActive = false;
                gNeut.SetActive(true);
                gFire.SetActive(false);
            }
        }
        // This is only for setting up sprites. Other gameplay logic will come later
    }

    IEnumerator ChachaBulletFire()
    {
        while (chachaActive == true)
        {
            cbFire.SetActive(true);
            yield return new WaitForSeconds(fireDelayRate);
            cbFire.SetActive(false);
            yield return new WaitForSeconds(fireDelayRate);
        }
    }
    public void ChaCha(InputAction.CallbackContext context)
    {
        if (context.started) // Check for if the input action "started" (or if you clicked)
        {
            if (meleeActive == false)
            {
                chachaActive = true;
                cNeut.SetActive(false);
                cFire.SetActive(true);
                StartCoroutine(ChachaBulletFire());
            }
        }

        if (context.canceled) // Check for button released
        {
            if (meleeActive == false)
            {
                chachaActive = false;
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