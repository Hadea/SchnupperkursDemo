using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySS : MonoBehaviour
{
    [SerializeField] private float MovementSpeed = 200;
    [SerializeField] private bool MoveDirectionRight = true;
    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        Vector2 rayOrigin = transform.position;
        rayOrigin.x += (MoveDirectionRight ? +0.6f : -0.6f);
        RaycastHit2D hitTarget = Physics2D.Raycast(rayOrigin, Vector2.down, 1f);
        if (hitTarget.collider == null)
        {
            MoveDirectionRight = !MoveDirectionRight;
        }

        rigidBody.velocity = MovementSpeed * Time.fixedDeltaTime * (MoveDirectionRight ? Vector2.right : Vector2.left);
    }
}
