using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float MaxHeigt;
    public float MinHeigt;

    public int Climate = 10;

    public ScoreManager scoreManager;

    public Text ClimateDisplay;
    // Update is called once per frame
    void Update()
    {
        ClimateDisplay.text = Climate.ToString();
        if (scoreManager.Health <= 0)
        {
            Destroy(gameObject);
        }
    
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxHeigt)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > MinHeigt)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }
    }
}
