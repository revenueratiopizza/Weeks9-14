using UnityEngine;

public class Fire : MonoBehaviour
{
    // I want to make game objects to call switching between fire sprite and neutral sprite

    public GameObject lNeut;
    public GameObject lFire;

    public GameObject rNeut;
    public GameObject rFire;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // I don't think we need anything in here right now
    }

    // Update is called once per frame
    void Update()
    {
        // If left click is checked
        // Then turn off gunny neutral and turn on gunny fire
        // Else turn on gunny neutral and turn off gunny fire

        if (Input.GetMouseButton(0))
        {
            lNeut.SetActive(false);
            lFire.SetActive(true);
        }
        else
        {
            lNeut.SetActive(true);
            lFire.SetActive(false);
        }

        // If right click is checked
        // Then turn off cha cha neutral and turn on cha cha fire
        // Else turn on cha cha neutral and turn off cha cha fire

        if (Input.GetMouseButton(0))
        {
            rNeut.SetActive(false);
            rFire.SetActive(true);
        }
        else
        {
            rNeut.SetActive(true);
            rFire.SetActive(false);
        }

        // Took from https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Input.GetMouseButton.html
    }
}
