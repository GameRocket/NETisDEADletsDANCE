using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    /// <summary>
    /// Reference to our player camera
    /// </summary>
    [SerializeFiled]
    private Camera cam;

    /// <summary>
    /// Checking after start
    /// </summary>
    void Start()
    {
        //  Check if camera inserted into camera slot
        if (cam == null)
        {
            Debug.LogError("PlayerShoot: No camera referenced!");
            this.enabled = false;
        }
    }
}
