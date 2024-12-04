using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCrystal : MonoBehaviour
{
    public globalsBehavior globals;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (globals.element == 3)
        {
            globals.windCharged = true;
        }
    }
}
