using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Go to game over scene after collision immediately
 */
public class Death : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene("GameOver");
    }
}
