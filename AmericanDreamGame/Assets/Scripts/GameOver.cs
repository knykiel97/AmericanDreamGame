using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

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
