using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Playermovement : MonoBehaviour
{  

    public Rigidbody rb;              
    public float speed = 10f;

    // // // // // //

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Code for forward movement:
        rb.velocity = 5 * new Vector3(2.5f, 0f, 0f);   
        //The above line will add a constant velocity to the rigidbody

        // // // // // //

        // Code for left and right movement:
        
        if(Input.GetKeyDown("d"))                               //To get input from player's keyboar
        {
           rb.addForce(100 * Time.deltaTime, 0, 0);
        }
        
        if(Input.GetKeyDown("a"))                               //To get input from player's keyboar
        {
           rb.addForce(-100 * Time.deltaTime, 0, 0);
        }
        
         //To move the rigidbody(rb) on input

    }


}
