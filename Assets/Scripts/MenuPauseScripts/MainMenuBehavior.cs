using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuBehavior : MonoBehaviour
{
    public GameObject controlPanel;
    public GameObject mainMenuPanel;
    public GameObject levelchoose;
    public GameObject creditsPanel;

    public Button startGame;
    public Button exitGame;
    public Button showControls;
    public Button exitControls;
    public Button level1;
    public Button exitLevels;
    public Button credits;
    public Button leaveCredits;

    public AudioSource mainMusic;
    // Start is called before the first frame update
    void Start()
    {
        creditsPanel.SetActive(false);
        controlPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
        levelchoose.SetActive(false);

        startGame.onClick.AddListener(()=> ChoseLevel());
        level1.onClick.AddListener(() => Level1());
        exitLevels.onClick.AddListener(()=> ExitLevels());
        exitGame.onClick.AddListener(() => ExitGame());
        showControls.onClick.AddListener(() => ShowControls());
        exitControls.onClick.AddListener(() => ExitControls());
        credits.onClick.AddListener(() => EnterCredits());
        leaveCredits.onClick.AddListener(() => LeavingCredits());

        mainMusic.Play();
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChoseLevel()
    {
        levelchoose.SetActive(true);
        mainMenuPanel.SetActive(false);
    }
    void Level1()
    {
        Debug.Log("Starting game");
        SceneManager.LoadScene(1);
    }
    void ExitLevels()
    {
        levelchoose.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
    void ExitGame()
    {
        Debug.Log("imagine game closing");
        Application.Quit();
    }
    void ShowControls()
    {
        controlPanel.SetActive(true);
        mainMenuPanel.SetActive(false);

    }
    void ExitControls()
    {
        controlPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    void EnterCredits()
    {
        mainMenuPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    void LeavingCredits()
    {
        mainMenuPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }
}
