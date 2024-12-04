using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBehavior : MonoBehaviour
{
    public globalsBehavior globals;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("FireFloor") || collision.CompareTag("WaterFloor") || collision.CompareTag("EarthFloor"))
        {
            globals.player.transform.position = globals.spawnPoint.transform.position;
            globals.windCharged = false;
        }
    }
}
