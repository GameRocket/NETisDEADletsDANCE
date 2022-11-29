using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerWeapon : MonoBehaviour
{
    /// <summary>
    /// Name of our weapon
    /// </summary>
    public string name = "Glock";

    /// <summary>
    /// Damage variable
    /// </summary>
    public float damage = 10f;

    /// <summary>
    /// Range of our weapon
    /// </summary>
    public float range = 100f;


}
