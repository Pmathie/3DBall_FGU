using UnityEngine;

public class Collectible : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        PlayerCoinCollector playerCoinCollector;

        if (other.GetComponent<PlayerCoinCollector>())
        {
            playerCoinCollector = other.GetComponent<PlayerCoinCollector>();
            playerCoinCollector.AddCoin();
            Destroy(gameObject);
        }
    }
}
