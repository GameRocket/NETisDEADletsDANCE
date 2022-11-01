using UnityEngine;

//  We want to always have rigid body with our player motor
[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    private Vector3 velocity = Vector3.zero;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Gets a movement vector from player controller
    /// </summary>
    /// <param name="_velocity"></param>
    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    /// <summary>
    /// Run every physics iteration
    /// </summary>
    void FixedUpdate()
    {
        PerformMovement();
    }

    //  Perform movement based on velocity variable
    void PerformMovement()
    {
        if ( velocity != Vector3.zero )
        {
            rb.MovePosition();
        }
    }
}
