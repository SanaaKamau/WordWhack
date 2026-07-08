using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public Button playButton;
    public Button settingsButton;

    void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
    }
    public void OnPlayButtonClicked()
    {   Debug.Log("Play button clicked!");
        SceneManager.LoadScene("GameplayScene");
    }
    public void OnSettingsButtonClicked()
    {
        Debug.Log("Settings button clicked!");
    }
}
