using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField playerNameInput;

    public void StartGame()
    {
        string playerName = playerNameInput.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }
}