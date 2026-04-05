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

        // If right click is checked
        // Then turn off cha cha neutral and turn on cha cha fire
    }
}
