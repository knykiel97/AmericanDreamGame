using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Manages LevelSelector scene
 */
public class LevelSelector : MonoBehaviour
{
    public void DemoLevel()
    {
        SceneManager.LoadScene("SampleLevel");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
