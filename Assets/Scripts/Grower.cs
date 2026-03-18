using System.Collections;
using UnityEngine;
public class Grower : MonoBehaviour
{
    public Transform tree;  // First initializing the transform functions for objects
    public Transform apple; // so we can use them to make them transform and grow
    public Coroutine initAllGrow;
    public Coroutine initTreeGrow;
    public Coroutine initAppleGrow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tree.localScale = Vector2.zero;  // Set tree and apple localScale in code instead of in the editor
        apple.localScale = Vector2.zero; // so we can easily edit it if needed
    }
    public void StartGrow()
    {
        if (initAllGrow != null)
        { StopCoroutine(initAllGrow); } // Ensure coroutine is stopped before starting a new one
        if (initTreeGrow != null)
        { StopCoroutine(initTreeGrow); } // Stop tree and apple separately as well
        if (initAppleGrow != null)
        { StopCoroutine(initAppleGrow); }
        initAllGrow = StartCoroutine(GrowCombo()); // Yield return cannot be in a public void
    }                                              // so I have to call them in a separate IEnumerator
    IEnumerator GrowCombo()
    {
        yield return initTreeGrow = StartCoroutine(GrowTree());   // This can also be done in quotes as long as you spell it EXACTLY right
        yield return initAppleGrow = StartCoroutine(GrowApple()); // It's always better to make sure you have a safety net when you do this stuff
    }
    IEnumerator GrowTree()
    {
        Debug.Log("Started growing Tree");
        tree.localScale = Vector2.zero;  // Setting size before the coroutine
        apple.localScale = Vector2.zero; // so the size isn't dumb huge or anything
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime; // This is to make the tree grow over time using deltaTime
            tree.localScale = Vector2.one * t; // Vector2.one is the same as setting the scale to 1.0, 1.0, but now it's multiplied by time
            yield return null; // Yield statement prevents the coroutine from looping forever, it's like a bookmark
        }
        Debug.Log("Finished growing Tree");
    }
    IEnumerator GrowApple()
    {
        Debug.Log("Started growing Apple");
        apple.localScale = Vector2.zero; // Don't set tree size in GrowApple because it'll just reset our hard work
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime; // This is to make the apple grow over time using deltaTime
            apple.localScale = Vector2.one * t; // Vector2.one is the same as setting the scale to 1.0, 1.0, but now it's multiplied by time
            yield return null; // Yield statement prevents the coroutine from looping forever, it's like a bookmark
        }
        Debug.Log("Finished growing Apple");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
