using System.Collections;
using UnityEngine;

public class Grower : MonoBehaviour
{
    public Transform tree;   // First initializing the transform functions for objects
    public Transform apple;  // so we can use them to make them transform and grow
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tree.localScale = Vector2.zero;    // Set tree and apple localScale in code instead of in the editor
        apple.localScale = Vector2.zero;   // so we can easily edit it if needed
    }


    IEnumerator GrowTree()
    {
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime; // This is to make the tree grow over time using deltaTime
            tree.localScale = Vector2.one * t; // Vector2.one is the same as setting the scale to 1.0, 1.0, but now it's multiplied by time
            yield return null; // Yield statement prevents the coroutine from looping forever, it's like a bookmark
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
