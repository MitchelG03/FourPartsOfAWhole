using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndBehavior : MonoBehaviour
{
    public GameObject reachedTheEnd;
    public Button level1Done;
    // Start is called before the first frame update
    void Start()
    {
        reachedTheEnd.SetActive(false);
        level1Done.onClick.AddListener(() => RetutnToMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        reachedTheEnd.SetActive(true);
        Cursor.visible = true;
    }

    void RetutnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
