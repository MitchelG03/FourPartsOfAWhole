using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthFloor : MonoBehaviour
{
    public globalsBehavior globals;
    public TextBoxBehavior boxBehavior;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (globals.element == 0)
        {
            boxBehavior.fireWalksOnEarth = true;
        }
        if (globals.element == 1)
        {
            boxBehavior.waterWalksOnEarth = true;
        }
        if (globals.element == 3)
        {
            boxBehavior.windWalksOnEarth = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boxBehavior.clearAll = true;
    }
}
