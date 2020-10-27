using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // METODO QUE RECIBE ESCENA Y CAMBIA ESCENA
    public void GoToScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
