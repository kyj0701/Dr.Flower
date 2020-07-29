using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float camera_size = 4;
    public float Camera_z = -10;
    Transform playerTransform;
    Vector3 Offset;
    
    void Awake()
    {
        Camera.main.orthographicSize = camera_size;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = playerTransform.position;
        Offset.z = Camera_z;
    }

    void LateUpdate()
    {
        Offset = playerTransform.position;
        Offset.z = Camera_z;
        transform.position = Offset;
    }
}
