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
        float x = CrossPlatformInputManager.GetAxisRaw("Horizontal");      //To get input from player's keyboard
        
        Vector3 moveby = transform.right * x * Time.deltaTime;
        rb.MovePosition(transform.position + moveby.normalized * speed * Time.deltaTime);  //To move the rigidbody(rb) on input

    }


}
