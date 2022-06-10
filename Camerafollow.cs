using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    // "offset" here will decide how far on your camera is placed from the player on each axis
    // "Transform" will give the position of player to the camera
    
    void Update()
    {
        transform.position = player.position + offset;
        
    }
    // This script is to be added on the camera in your game
}
