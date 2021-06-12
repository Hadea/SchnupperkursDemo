using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float CameraSpeed = 0.2f;

    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void Update()
    {
        Vector3 targetPos = player.transform.position;
        targetPos.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, targetPos, CameraSpeed * Time.deltaTime);
    }
}
