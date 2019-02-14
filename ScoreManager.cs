using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int Health = 10;
    public Text HealthDisplay;

    private void Update()
    {
        HealthDisplay.text = Health.ToString();

        if (Health <= 0)
        {
            SceneManager.LoadScene("Gameover");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Health--;
            Debug.Log(Health);
        }
    }
}
