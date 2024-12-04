using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFloor : MonoBehaviour
{
    public globalsBehavior globals;
    public TextBoxBehavior boxBehavior;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (globals.element == 0)
        {
            boxBehavior.fireWalksOnWater = true;
        }
        if (globals.element == 2)
        {
            boxBehavior.earthWalksOnWater = true;
        }
        if (globals.element == 3)
        {
            boxBehavior.windWalksOnWater = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boxBehavior.clearAll = true;
    }
}
