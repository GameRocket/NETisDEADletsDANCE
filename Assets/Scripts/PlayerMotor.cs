using UnityEngine;

/// <summary>
/// <b>This script created to calculate player velocity</b>
/// <para>We want to always have rigid body with our player motor</para>
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    /// <summary>
    /// Private variable for velocity that will be used in this class
    /// </summary>
    private Vector3 velocity = Vector3.zero;

    /// <summary>
    /// Rigidbody variable
    /// </summary>
    private Rigidbody rb;

    /// <summary>
    /// Get a rigidbody
    /// </summary>
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

    /// <summary>
    /// Perform movement based on velocity variable
    /// </summary>
    void PerformMovement()
    {
        //  Check if velocity was changed at +least once already
        if ( velocity != Vector3.zero )
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }
}
