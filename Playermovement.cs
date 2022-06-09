using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Playermovement : MonoBehaviour
{   // Code for ad movement:
    Rigidbody rb;
    public float speed = 10f;

    // // // // // //

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // Code for forward movement:
        rb.velocity = 5 * new Vector3(2.5f, 0f, 0f);

        // // // // // //

        // Code for ad movement:
        float x = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        Vector3 moveby = transform.right * x * Time.deltaTime;

        rb.MovePosition(transform.position + moveby.normalized * speed * Time.deltaTime);

        // // // // // //

    }


}
