using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Stores player lifes, updates corresponding GUI element and if player die, switch to GameOver scene
 */
public class PlayerLifes : MonoBehaviour
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
    public static int Lifes = 3;
}
