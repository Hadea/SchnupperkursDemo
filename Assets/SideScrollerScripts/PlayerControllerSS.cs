using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSS : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField] private float JumpForce;
    [SerializeField] private float Speed;
    bool jumpNeeded = false;
    float movementNeeded = 0;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpNeeded = true;
        }
        movementNeeded = Input.GetAxis("Horizontal");

    }

    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(movementNeeded * Speed * Time.fixedDeltaTime, rigidBody.velocity.y );

        if (jumpNeeded)
        {
            rigidBody.AddForce(Vector2.up * JumpForce);
            jumpNeeded = false;
        }

    }
}
