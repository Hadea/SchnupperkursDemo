using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform DebugRedDot;
    [SerializeField] private Rigidbody2D PlayerRigidBody;
    void Update()
    {
        DebugRedDot.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.LookAt(DebugRedDot);


    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRigidBody.AddForce(Vector2.up);
        }
    }
}
