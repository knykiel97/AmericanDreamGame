using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void DemoLevel()
    {
        SceneManager.LoadScene("SampleLevel");
    }

    public void Level1()
    {

    }

    public void Level2()
    {

    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
