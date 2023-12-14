using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIMenuHandler : MonoBehaviour
{
    public TMP_Text highScore;
    public TMP_InputField playerNameInput;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.HighScoreName != null)
        {
            highScore.text = GameManager.Instance.HighScoreName + " . . . " + GameManager.Instance.HighScore;
        }
    }

    public void SetPlayerName()
    {
        GameManager.Instance.PlayerName = playerNameInput.text;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
