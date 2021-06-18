using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Switches to Level Selector if player go through door
 */
public class LevelExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (!col.gameObject.CompareTag("Player")) return;

        ScoringSystem.Score = 0;
        PlayerLifes.Lifes = 3;
        SceneManager.LoadScene("LevelSelector");
    }
}
