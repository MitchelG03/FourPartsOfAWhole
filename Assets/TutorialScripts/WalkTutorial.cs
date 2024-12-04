using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalkTutorial : MonoBehaviour
{
    public GameObject textBox;
    public GameObject textTutorialWalk;
    public Button buttonTutorialDone;

    // Start is called before the first frame update
    void Start()
    {
        textTutorialWalk.SetActive(false);
        buttonTutorialDone.onClick.AddListener(() => TutorialWaldDone());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textTutorialWalk.SetActive(true);
        textBox.SetActive(true);
        Time.timeScale = 0f;
    }

    void TutorialWaldDone()
    {
        Time.timeScale = 1f;
        textBox.SetActive(false);
        Destroy(gameObject);
    }
}
