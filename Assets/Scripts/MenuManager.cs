using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject playWindow;
    public GameObject settingsWindow;

    public Button playButton;
    public Button settingsButton;

    void Start()
    {
        playButton.onClick.AddListener(() => ToggleWindowVisibility(playWindow));
        settingsButton.onClick.AddListener(() => ToggleWindowVisibility(settingsWindow));
    }

    public void ToggleWindowVisibility(GameObject window)
    {
        bool isActive = window.activeSelf;
        window.SetActive(!isActive);

        bool playWindowActive = playWindow.activeSelf;
        bool settingsWindowActive = settingsWindow.activeSelf;

        playButton.gameObject.SetActive(!playWindowActive && !settingsWindowActive);
        settingsButton.gameObject.SetActive(!playWindowActive && !settingsWindowActive);
    }
}