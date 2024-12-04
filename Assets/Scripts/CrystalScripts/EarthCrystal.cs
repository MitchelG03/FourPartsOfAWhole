using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthCrystal : MonoBehaviour
{
    public globalsBehavior globals;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (globals.element == 2)
        {
            globals.earthCharged = true;
        }
    }
}
