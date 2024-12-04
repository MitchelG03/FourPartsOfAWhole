using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrierTutorial : MonoBehaviour
{
    public GameObject textbox;
    public GameObject textTutorialBarrier;
    public Button tutorialDone;
    // Start is called before the first frame update
    void Start()
    {
        textTutorialBarrier.SetActive(false);
        tutorialDone.onClick.AddListener(() => TutorialBarrierDone());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textbox.SetActive(true);
        textTutorialBarrier.SetActive(true);
        Time.timeScale = 0f;
    }

    void TutorialBarrierDone()
    {
        textbox.SetActive(false);
        Time.timeScale = 1f;
        Destroy(gameObject);
    }
}
