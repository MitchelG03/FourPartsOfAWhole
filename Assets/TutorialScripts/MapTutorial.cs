using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapTutorial : MonoBehaviour
{
    public GameObject textBox;
    public GameObject textMapTutorial;
    public Button mapTutorialDone;

    // Start is called before the first frame update
    void Start()
    {
        textMapTutorial.SetActive(false);
        mapTutorialDone.onClick.AddListener(() => TutorialDone());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textMapTutorial.SetActive(true);
        textBox.SetActive(true);
        Time.timeScale = 0F;
    }
    void TutorialDone()
    {
        Time.timeScale = 1f;
        textBox.SetActive(false);
        Destroy(gameObject);
    }
}
