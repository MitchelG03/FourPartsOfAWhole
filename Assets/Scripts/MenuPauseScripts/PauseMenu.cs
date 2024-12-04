using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public Button closePauseMenu;
    public Button returnToMenu;
    public bool gamePaused;
    public GameObject elementWheel;
    public globalsBehavior globals;
    public GameObject realHUD;
    public GameObject map;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        map.SetActive(false);
        realHUD.SetActive(true);

        gamePaused = false;
        Cursor.visible = false;

        closePauseMenu.onClick.AddListener(() => ClosePauseMenu());
        returnToMenu.onClick.AddListener(() => ReturnToMenu());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0)
            {
                ClosePauseMenu();
            }
            else
            {
                OpenPauseMenu();
            } 
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (Time.timeScale == 0)
            {
                ClosePauseMenu();
            }
            else
            {
                map.SetActive(true);
                realHUD.SetActive(false);
                Time.timeScale = 0f;
            }  
        }
    }

    void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    void OpenPauseMenu()
    {
        Time.timeScale = 0f;
        gamePaused = true;
        pauseMenu.SetActive(true);
        Cursor.visible = true;
        TurnTheElementWheel();
    }
    void ClosePauseMenu()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        map.SetActive(false);
        realHUD.SetActive(true);
        gamePaused = false;
        Cursor.visible = false;
    }

    void TurnTheElementWheel()
    {
        if (globals.element == 0)
        {
            elementWheel.transform.eulerAngles = new Vector3(0, 0, 135);
        }
        if (globals.element == 1)
        {
            elementWheel.transform.eulerAngles = new Vector3(0, 0, -135);
        }
        if (globals.element == 2)
        {
            elementWheel.transform.eulerAngles = new Vector3(0, 0, 45);
        }
        if (globals.element == 3)
        {
            elementWheel.transform.eulerAngles = new Vector3(0, 0, -45);
        }
    }
}
