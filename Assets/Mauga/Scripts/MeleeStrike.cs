using System.Collections;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.UI;
using UnityEngine.Windows;

public class MeleeStrike : MonoBehaviour
{
    // I want to turn off all other sprites when this event is called

    public GameObject melee;
    public float targetTime = 0.5f;
    public float meleeTime = 0f;
    IEnumerator MeleeTimer()
    {
        while (meleeTime < 0.5f)
        {
            meleeTime += Time.deltaTime;
            yield return null;
        }
    }

    public void Melee(InputAction.CallbackContext context)
    {
        if (context.started) // Check for if the input action "started" (or if you clicked)
        {
            if (meleeTime < 0.5f) {
                StartCoroutine(MeleeTimer());
                melee.SetActive(true);
            }
            if (meleeTime > 0.5f)
            {
                melee.SetActive(false);
            }
        }
        // This is only for setting up sprites. Other gameplay logic will come later
    }

    void Loop()
    {
        print(meleeTime);
    }

    // Using https://docs.unity3d.com/6000.3/Documentation/Manual/Coroutines.html to set stuff up
}

// Thank you GeorgeRigato https://discussions.unity.com/t/simple-timer/56201/2