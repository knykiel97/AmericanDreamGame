using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * After death clear-up variables and after 5 seconds switch to MainMenu.
 */
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        ScoringSystem.Score = 0;
        PlayerLifes.Lifes = 3;
        StartCoroutine(BackToMainMenu());
    }

    private IEnumerator BackToMainMenu()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("MainMenu");
    }
}
