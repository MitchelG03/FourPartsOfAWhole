using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthBarrier : MonoBehaviour
{
    public globalsBehavior globals;
    public TextBoxBehavior boxBehvavior;
    public GameObject earthBarrierOpen;
    public AudioSource earthBarrierDestroySound;

    // Start is called before the first frame update
    void Start()
    {
        earthBarrierOpen.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boxBehvavior.clearAll = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Retractable();
    }

    void Retractable()
    {
        if (globals.earthCharged == true)
        {
            earthBarrierDestroySound.Play();
            earthBarrierOpen.SetActive(true);
            Invoke("Retracted", 2);
        }
        else
        {
            if (globals.element <= 1)
            {
                boxBehvavior.fireWMeetsEarth = true;
            }
            if (globals.element == 2)
            {
                boxBehvavior.earthMeetsEarth = true;
            }
            if (globals.element == 3)
            {
                boxBehvavior.windMeetsEarth = true;
            }
        }
    }

    void Retracted()
    {
        Destroy(gameObject);
    }
}
