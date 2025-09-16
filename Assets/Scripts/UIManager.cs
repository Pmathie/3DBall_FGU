using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public static UIManager Instance;
    public TextMeshProUGUI coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    public void UpdateCoinCount(int numberOfCoins)
    {
        Debug.Log("Updating coin count to: " + numberOfCoins);
        coinText.text = "Coins: " + numberOfCoins;
    }


}
