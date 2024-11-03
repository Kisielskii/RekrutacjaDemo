using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimedLightScript : MonoBehaviour
{
    public Light light;
    public Collider collider;
    public bool isBlinking;
    public float timeDelay;
    void Update()
    {
        if(isBlinking == false)
        {
            StartCoroutine(Blink());
        }
    }

    IEnumerator Blink()
    {
        isBlinking = true;
        light.enabled = false;
        collider.enabled = false;
        yield return new WaitForSeconds(timeDelay);
        light.enabled = true;
        collider.enabled = true;
        yield return new WaitForSeconds(timeDelay);
        isBlinking = false;
    }
}
