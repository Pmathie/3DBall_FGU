using UnityEngine;

public class Respawner : MonoBehaviour
{
    
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BallMovement>())
        {
            other.GetComponent<BallMovement>().Respawn();
        }
    }
}
