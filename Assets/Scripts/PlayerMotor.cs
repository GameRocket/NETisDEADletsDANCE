using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  We want to always have rigid body with our player motor
[RequireComponent(typeof(RigidBody))]

public class PlayerMotor : MonoBehaviour
{
    /// <summary>
    /// Player speed
    /// </summary>
    [SerializeField]
    private float speed = 5f;

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
        //  Horizontal movement
        float _xMov = Input.GetAxisRaw("Horizotal");

        //  Vertical movement
        float _zMov = Input.GetAxisRaw("Vertical");

    }
}
