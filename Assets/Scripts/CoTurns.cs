using System.Collections;
using UnityEngine;

public class CoTurns : MonoBehaviour
{
    public Transform Hero;
    public Coroutine SwingCort;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        Hero.localPosition = new Vector2(-600, 200);
    }
    public void Swing()
    {
        SwingCort = StartCoroutine(HeroSwing());
    }    
    public IEnumerator HeroSwing()
    {
        Debug.Log("Started swinging");
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            Hero.localPosition = new Vector2((-600 + (150 * t)), 200);
            // Interpolate between x = -600 and x = -450
            // Then interpolate back
            yield return null;
        }
        Debug.Log("Finished swinging");
    }

    // Update is called once per frame
    public void Update()
    {

    }
}
