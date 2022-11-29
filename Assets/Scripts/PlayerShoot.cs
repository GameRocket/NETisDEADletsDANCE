using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    /// <summary>
    /// Reference to our weapon class
    /// </summary>
    public PlayerWeapon weapon;

    /// <summary>
    /// Reference to our player camera
    /// </summary>
    [SerializeField]
    private Camera cam;

    /// <summary>
    /// Allows to control that we hit in Unity
    /// </summary>
    [SerializeField]
    private LayerMask mask;

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

    void Update()
    {
        //  Check if we get some input
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    /// <summary>
    /// In this method we will do RayCast
    /// </summary>
    void Shoot()
    {
        RaycastHit _hit;

        //  Checking if we hit something
        if( Physics.Raycast(cam.transform.position, cam.transform.forward, out _hit, weapon.range, mask) )
        {
            Debug.Log("We hit " + _hit.collider.name);
        }
    }
}
