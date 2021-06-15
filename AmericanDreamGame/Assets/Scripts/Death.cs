using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene("GameOver");
    }
}
