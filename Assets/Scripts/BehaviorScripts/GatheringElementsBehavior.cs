using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatheringElementsBehavior : MonoBehaviour
{
    public globalsBehavior globals;

    // Start is called before the first frame update
    void Start()
    {
        globals.elementBlocker = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            globals.elementBlocker = globals.elementBlocker + 1;
            Destroy(gameObject);
            Debug.Log("FixedWithDucktTabe");
        }
    }
}
