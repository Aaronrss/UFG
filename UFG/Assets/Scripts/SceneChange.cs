/*
    SCRIPT THAT CHANGE SCENES
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // METHOD THAT RECIVES THE SCENE AND CHANGE IT
    public void GoToScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
