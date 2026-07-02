using UnityEngine;
using UnityEngine.UI;

public class UIScript
{
    public Button playButton;
    public Button settingsButton;

    void awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
    }
    public void OnPlayButtonClicked()
    {     
        Debug.Log("Play button clicked!");
    }
    public void OnSettingsButtonClicked()
    {
        Debug.Log("Settings button clicked!");
    }
}
