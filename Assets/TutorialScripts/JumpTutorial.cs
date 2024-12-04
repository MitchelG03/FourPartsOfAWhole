using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpTutorial : MonoBehaviour
{
    public GameObject textBox;
    public GameObject textTutorialJump;
    public Button tutorialDone;

    // Start is called before the first frame update
    void Start()
    {
        textTutorialJump.SetActive(false);
        tutorialDone.onClick.AddListener(() => TutorialJumpDone());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textTutorialJump.SetActive(true);
        textBox.SetActive(true);
        Time.timeScale = 0f;
    }

    void TutorialJumpDone()
    {
        textBox.SetActive(false);
        Time.timeScale = 1f;
        Destroy(gameObject);
    }
}
