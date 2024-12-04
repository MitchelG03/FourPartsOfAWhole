using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalsBehavior : MonoBehaviour
{
    public int element;
    public int elementBlocker = 1;
    public bool powerCharged;
    public GameObject spawnPoint;
    public GameObject player;

    public bool fireCharged;
    public bool waterCharged;
    public bool earthCharged;
    public bool windCharged;

    void Start()
    {
        spawnPoint.transform.position = new Vector2(-49.5f,-22.3f);
        fireCharged = false;
        waterCharged = false;
        earthCharged = false;
        windCharged = false;

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
