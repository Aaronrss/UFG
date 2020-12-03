/*
    SCRIPT THAT MANAGE THE PREFABS (SELECT NUMBER OF PLAYER, CHARACTERS AND STAGES)
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class Prefs : MonoBehaviour
{
    // METHOD TO SELECT PLAYER
    public void PlayerSelect(int players)
    {
        PlayerPrefs.SetInt("Players", players);
        PlayerPrefs.SetInt("CurrentPlayer", 1);
        SceneManager.LoadScene("CharacterSelect");
    }
    // METHOD TO SELECT CHARACTER
    public void CharacterSelect(int character)
    {
        int player = PlayerPrefs.GetInt("CurrentPlayer");
        PlayerPrefs.SetInt("Character" + player, character);
        if (PlayerPrefs.GetInt("Players") == 2 && PlayerPrefs.GetInt("CurrentPlayer") == 1)
        {
            PlayerPrefs.SetInt("CurrentPlayer", 2);
            SceneManager.LoadScene("CharacterSelect");
        }
        else
        {
            SceneManager.LoadScene("StageSelect");
        }
    }

    // METHOD TO SELECT STAGES
    public void StageSelect(int stage)
    {
        PlayerPrefs.SetInt("Stage", stage);
        SceneManager.LoadScene("Fight");
    }
}