using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FireBarrier : MonoBehaviour
{
    public globalsBehavior globals;
    public TextBoxBehavior boxBehavior;
    public AudioSource fireBarrierDestroyed;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boxBehavior.clearAll = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Burnable();
    }

    void Burnable()
    {
        if (globals.fireCharged == true)
        {
            fireBarrierDestroyed.Play();
            Invoke("Burned", 2f);
        }
        else
        {
            if (globals.element == 0)
            {
                boxBehavior.fireMeetsFire = true;
            }
            if (globals.element == 1)
            {
                boxBehavior.waterMeetsFire = true;
            }
            if (globals.element >= 2)
            {
                boxBehavior.earthWindMeetsFire = true;
            }
        }
    }

    void Burned()
    {
        Destroy(gameObject);
    }
}
