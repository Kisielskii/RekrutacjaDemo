using UnityEngine;

public class DestryPlayer : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Light")
        {
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
        Debug.Log("Destroyed");
        }
        
}
}