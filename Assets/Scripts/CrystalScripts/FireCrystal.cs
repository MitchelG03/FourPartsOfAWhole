using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCrystal : MonoBehaviour
{
    public globalsBehavior globals;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (globals.element == 0)
        {
            globals.fireCharged = true;
        }
    }
}
