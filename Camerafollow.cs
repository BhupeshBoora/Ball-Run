using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    void Update()
    {
        transform.position = player.position + offset;
        // "offset" here will decide how far on your camera is placed from the player on each axis
        
    }
}
