
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody Component called "rb"
    public Rigidbody rb;
    
    // Use Fixed update when working with physics instead of Update
    // 
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);   // Add a force of 2000 on the z-axis
    }
}
