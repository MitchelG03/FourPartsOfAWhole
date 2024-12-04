using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFloor : MonoBehaviour
{
    public globalsBehavior globals;
    public TextBoxBehavior boxBhevaior;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (globals.element == 1)
        {
            boxBhevaior.waterWalksOnFire = true;
        }
        if (globals.element == 2)
        {
            boxBhevaior.earthWalksOnFire = true;
        }
        if (globals.element == 3)
        {
            boxBhevaior.windWalksOnFire = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boxBhevaior.clearAll = true;
    }
}
