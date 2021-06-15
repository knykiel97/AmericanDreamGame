using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        lifeTextBox.GetComponent<Text>().text = "Remaining lifes: " + Lifes;

        if (Lifes == 0)
        {
            GameOverScene();
        }
    }

    private void GameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    [SerializeField] private GameObject lifeTextBox;
    [SerializeField] public static int Lifes = 3;
}
