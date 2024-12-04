using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCrystal : MonoBehaviour
{
    public globalsBehavior globals;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (globals.element == 1)
        {
            globals.waterCharged = true;
        }
    }
}
