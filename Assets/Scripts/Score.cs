using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        ScoreText.text = "Coins: " + count.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            count++;
            ScoreText.text = "Coins: " + count.ToString();
            Destroy(collision.gameObject);
        }
    }
}
