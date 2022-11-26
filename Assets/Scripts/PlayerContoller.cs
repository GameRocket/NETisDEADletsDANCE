using UnityEngine;

/// <summary>
/// <b>This script is used to edit default player controller</b>
/// <para>Than we add a PlayerController it add a PlayerMotor which add a Rigidbody</para>
/// </summary>
[RequireComponent(typeof(PlayerMotor))]
public class PlayerContoller : MonoBehaviour
{
    /// <summary>
    /// Player speed
    /// </summary>
    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float lookSensitivity = 3f;

    /// <summary>
    /// Player motor reference
    /// </summary>
    private PlayerMotor motor;

    /// <summary>
    /// After player start movements
    /// </summary>
    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    /// <summary>
    /// Calculate movement velocity as a 3D Vector
    /// </summary>
    void Update()
    {
        //  In next steps we calculating velocity as a 3D Vector

        //  Horizontal movement
        float _xMov = Input.GetAxisRaw("Horizontal");

        //  Vertical movement
        float _zMov = Input.GetAxisRaw("Vertical");

        //  Perform horizontal movement
        Vector3 _movHorizotal = transform.right * _xMov;    //  Value that will change: (1, 0, 0)

        //  Perform vertical movement
        Vector3 _movVertical = transform.forward * _zMov;   //  Value that will change: (0, 0, 1)

        //  Calculating direction of velocity vector and multiply by current speed variable
        Vector3 _velocity = (_movHorizotal + _movVertical).normalized * speed;

        //  Apply movement our movement vector
        motor.Move(_velocity);

        //  Calculate rotation as a 3D vector
        //  Turning around
        float _yRot = Input.GetAxisRaw("Mouse X");

        //  Calculate local rotation
        Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;

        //  Apply rotation
        motor.Rotate(_rotation);

        //  Calculate camera rotation as a 3D vector
        float _xRot = Input.GetAxisRaw("Mouse Y");

        //  Calculate local rotation
        Vector3 _cameraRotation = new Vector3(0f, _xRot, 0f) * lookSensitivity;

        //  Apply rotation
        motor.RotateCamera(_cameraRotation);
    }
}
