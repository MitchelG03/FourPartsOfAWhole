using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTutorial : MonoBehaviour
{
    public GameObject textBox;
    public GameObject textChangeTutorial;
    public Button changeTutorialDone;

    // Start is called before the first frame update
    void Start()
    {
        textChangeTutorial.SetActive(false);
        changeTutorialDone.onClick.AddListener(() => TutorialChangeDone());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textChangeTutorial.SetActive(true);
        textBox.SetActive(true);
        Time.timeScale = 0f;
    }
    void TutorialChangeDone()
    {
        Time.timeScale = 1f;
        textBox.SetActive(false);
        Destroy(gameObject);
    }
}
