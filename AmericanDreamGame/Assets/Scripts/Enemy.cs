using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            PlayerLifes.Lifes--;
        }
    }
}
