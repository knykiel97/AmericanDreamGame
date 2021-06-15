using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerLives.Lifes--;
        }
    }
}
