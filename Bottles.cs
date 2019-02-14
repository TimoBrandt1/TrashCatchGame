using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottles : MonoBehaviour
{

    public int increase = 1;
    public float speed;

    public GameObject effect;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Instantiate(effect, transform.position, Quaternion.identity);

            //Player gets more climate
            other.GetComponent<Player>().Climate += increase;
            Debug.Log(other.GetComponent<Player>().Climate);
            Destroy(gameObject);
        }
    }
}
