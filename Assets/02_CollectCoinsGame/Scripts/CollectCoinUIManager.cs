using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

/// <summary>
/// Coin collect manager will handle all the functions related to coin collection
/// </summary>
namespace CollectCoins
{
    public class CollectCoinUIManager : MonoBehaviour
    {
        public TextMeshProUGUI coinsCollectedTxt;
        public Button restartBtn , menuBtn;

        int coinScore = 0;

        void Start()
        {
            restartBtn.onClick.AddListener(()=> {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            });

            menuBtn.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("Menu");
            });
        }

        public void CoinCollected() 
        {
            coinScore++;
            coinsCollectedTxt.text = "Coins Collected : " + coinScore;
        }
    }
}
