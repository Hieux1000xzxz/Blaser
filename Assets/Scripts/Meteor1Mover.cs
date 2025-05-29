using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor1Mover : MonoBehaviour
{
    public float speed = -3f;
    Rigidbody2D rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(1f, -1f).normalized * Mathf.Abs(speed);
    }
}
