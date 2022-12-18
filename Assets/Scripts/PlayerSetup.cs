using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    Behaviour[] componentsToDisable;

    bool isLocalPlayer = false;

    void Start()
    {
        if(!isLocalPlayer)
        {
            for ( int i = 0; i < componentsToDisable.Length; i++ )
            {
                componentsToDisable[i].enabled = false;
            }
        }
    }
}
