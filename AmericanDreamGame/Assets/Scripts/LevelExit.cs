using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (!col.gameObject.CompareTag("Player")) return;

        ScoringSystem.Score = 0;
        PlayerLifes.Lifes = 0;
        SceneManager.LoadScene("LevelSelector");
    }
}
