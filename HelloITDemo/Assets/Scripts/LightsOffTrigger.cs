using UnityEngine;

public class LightsOffTrigger : MonoBehaviour
{
    public Light lightt;
    public Collider collider;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Box")
        {
            Debug.Log("Turn Off");
            
            lightt.enabled = false;
            collider.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Box")
        {
            lightt.enabled = true;
            collider.enabled = true;
        }
    }
}

   
