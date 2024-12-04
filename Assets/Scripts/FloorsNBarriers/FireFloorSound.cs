using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFloorSound : MonoBehaviour
{
    public AudioSource fireCrackling;
    public AudioSource backgroundMusic;

    private void Start()
    {
        backgroundMusic.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        fireCrackling.Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        fireCrackling.Stop();
    }
}
