using UnityEngine;

public class PlayerCoinCollector : MonoBehaviour
{
    public int coinCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public void AddCoin()
    {
        coinCount++; 
        UIManager.Instance.UpdateCoinCount(coinCount);
    }
}
