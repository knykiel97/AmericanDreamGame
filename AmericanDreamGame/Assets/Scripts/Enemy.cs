using UnityEngine;

/*
 * Remove life if player collide with object
 */
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
