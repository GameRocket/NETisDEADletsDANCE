using UnityEngine;

/// <summary>
/// <b>This script created to calculate player velocity</b>
/// <para>We want to always have rigid body with our player motor</para>
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    /// <summary>
    /// Optional variable reference to our camera
    /// If we don't have a camera we wan't to control, the rotation will be around the Y
    /// If we will use it rotation will be around Y and X
    /// </summary>
    [SerializeField]
    private Camera cam;

    /// <summary>
    /// Private variable for velocity
    /// </summary>
    private Vector3 velocity = Vector3.zero;

    /// <summary>
    /// Private variable for rotation
    /// </summary>
    private Vector3 rotation = Vector3.zero;

    /// <summary>
    /// 
    /// </summary>
    private Vector3 cameraRotation = Vector3.zero;

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
    /// Gets a rotational vector
    /// </summary>
    /// <param name="_rotation"></param>
    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation;
    }

    public void RotateCamera(Vector3 _cameraRotation)
    {
        cameraRotation = _cameraRotation;
    }

    /// <summary>
    /// Run every physics iteration
    /// </summary>
    void FixedUpdate()
    {
        PerformMovement();
        PerformRotation();
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

    /// <summary>
    /// Perform rotation based on rotation variable
    /// </summary>
    void PerformRotation()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
    }
}
