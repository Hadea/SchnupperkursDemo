using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTD : MonoBehaviour
{
    [SerializeField] private Transform DebugPoint;
    
    private Rigidbody2D rigidBody;
    private Vector2 movementRequested;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 worldCoordinatesOfMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldCoordinatesOfMouse.z = 0;
        DebugPoint.position = worldCoordinatesOfMouse;

        // controls einlesen
        movementRequested.x = Input.GetAxis("Horizontal");
        movementRequested.y = Input.GetAxis("Vertical");

        worldCoordinatesOfMouse.ToVector2();
    }

    private void FixedUpdate()
    {
       rigidBody.ve
        // bewegung ausführen
    }
}
