using UnityEngine;
using UnityEngine.InputSystem;

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
        print("Hello");
    }
}
