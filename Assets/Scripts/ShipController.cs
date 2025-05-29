using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject bulletPrefab;
    private AudioSource audioSource;
    public float speed = 10f;
    public float xLimit = 7f;
    public float reloadTime = 0.5f;
    public AudioClip shootSound;
    public AudioClip crashSound;
    float elapsedTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(moveX * speed * Time.deltaTime, 0f, 0f);
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
        transform.position = position;
        if (Input.GetButtonDown("Jump") && elapsedTime > reloadTime)
        {
            audioSource.PlayOneShot(shootSound);
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab,spawnPos,Quaternion.identity);
            elapsedTime = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
 
        audioSource.PlayOneShot(crashSound);
        gameManager.playerDied();
    }
}
