using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBarrier : MonoBehaviour
{
    public globalsBehavior globals;
    public TextBoxBehavior boxbehavior;
    public AudioSource windBarrierDestroySound;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boxbehavior.clearAll = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        smokeBeGone();
    }

    void smokeBeGone()
    {

        if (globals.windCharged == true)
        {
            windBarrierDestroySound.Play();
            Invoke("SmokeGone", 2.5f);

        }
        else
        {
            if (globals.element == 0)
            {
                boxbehavior.fireMeetsWind = true;
            }
            if (globals.element == 1)
            {
                boxbehavior.waterMeetsWind = true;
            }
            if (globals.element == 2)
            {
                boxbehavior.earthMeetsWind = true;
            }
            if (globals.element == 3)
            {
                boxbehavior.windMeetsWind = true;
            }
        }

    }

    void SmokeGone()
    {
        Destroy(gameObject);
    }
}
