using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    GameManager gameManager;
 
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2 (0f, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Tìm kiếm object Meteor và phá hủy
        if (collision.gameObject.CompareTag("Meteor"))
        {
            Destroy(collision.gameObject);
        }
        gameManager.AddScore();
        Destroy(gameObject);
    }
}
