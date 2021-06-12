using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTD : MonoBehaviour
{
    [SerializeField] private Transform DebugPoint;
    [SerializeField] private float MovementSpeed = 100;

    private Rigidbody2D rigidBody;
    private Vector2 movementRequested;
    private float angle;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 worldCoordinatesOfMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldCoordinatesOfMouse.z = 0;
        DebugPoint.position = worldCoordinatesOfMouse;

        Vector3 direction = (transform.position - worldCoordinatesOfMouse).normalized;

        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // controls einlesen
        movementRequested.x = Input.GetAxis("Horizontal");
        movementRequested.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // bewegung ausführen
        rigidBody.velocity = movementRequested.normalized * Time.fixedDeltaTime * MovementSpeed;
        rigidBody.MoveRotation(angle);
    }
}
