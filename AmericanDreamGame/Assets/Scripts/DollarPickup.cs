using UnityEngine;

/*
 * Add points if player collide with dollar
 */
public class DollarPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (!col.gameObject.CompareTag("Player")) return;

        ScoringSystem.Score += dollarScore;
        transform.position = new Vector3(0, 1000, 0);
    }

    private int dollarScore = 5;
}
