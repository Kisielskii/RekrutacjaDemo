using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomFliker : MonoBehaviour
{
    public Light light;
    public bool isFlickering;
    public float timeDelay;

    public GameObject explosion;
    
    private void Update() {
        if(isFlickering == false)
        {
            StartCoroutine(Flicker());
        }
    }
    IEnumerator Flicker()
    {
        isFlickering = true;
        light.enabled = false;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        light.enabled = true;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}