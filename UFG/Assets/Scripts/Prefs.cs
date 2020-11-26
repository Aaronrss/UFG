using UnityEngine;
using UnityEngine.SceneManagement;

public class Prefs : MonoBehaviour
{
    public void PlayerSelect(int players)
    {
        PlayerPrefs.SetInt("Players", players);
        SceneManager.LoadScene("CharacterSelect");
    }
    public void CharacterSelect(int character)
    {
        PlayerPrefs.SetInt("Character1", character);
    }
    public void StageSelect(int stage)
    {
        PlayerPrefs.SetInt("Stage", stage);
        SceneManager.LoadScene("Fight");
    }
}