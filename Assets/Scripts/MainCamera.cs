using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float camera_size = 4;
    public float Camera_z = -10;
    Transform playerTransform;
    Transform rainTransform;
    Vector3 Offset;
    Vector3 rainpos;
    public ParticleSystem rain;
    public bool israin;
    
    void Awake()
    {
        Camera.main.orthographicSize = camera_size;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = playerTransform.position;
        Offset.z = Camera_z;
        Offset.y += 1;
        rainTransform = playerTransform;
    }

    void Update()
    {
        if (israin)
        {    
            rain.Play();
            rainpos = rainTransform.position;
            rainpos.x -= 4;
            rainpos.y += 10;
            rain.transform.position = rainpos;
        }
        else
            rain.Stop();
    }

    void LateUpdate()
    {
        Offset = playerTransform.position;
        Offset.y += 1;
        Offset.z = Camera_z;
        transform.position = Offset;
    }
}
