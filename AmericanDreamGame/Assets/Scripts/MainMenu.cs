using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelector");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
