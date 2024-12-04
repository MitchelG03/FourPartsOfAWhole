using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBarrier : MonoBehaviour
{
    public globalsBehavior globals;
    public TextBoxBehavior boxBehavior;
    public GameObject waterBarrierOpen;
    public AudioSource waterbarrierdestroySound;

    // Start is called before the first frame update
    void Start()
    {
        waterBarrierOpen.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boxBehavior.clearAll = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Meltable();
    }

    void Meltable()
    {
        if (globals.waterCharged == true)
        {
            waterbarrierdestroySound.Play();
            Invoke("Melted", 3);
        }
        else
        {
            if (globals.element == 0)
            {
                boxBehavior.fireMeetsWater = true;
            }
            if (globals.element == 1)
            {
                boxBehavior.waterMeetsWater = true;
            }
            if (globals.element >= 2)
            {
                boxBehavior.earthWindMeetsWater = true;
            }
        }
    }

    void Melted()
    {
        waterBarrierOpen.SetActive(true);
        Destroy(gameObject);
    }
}
