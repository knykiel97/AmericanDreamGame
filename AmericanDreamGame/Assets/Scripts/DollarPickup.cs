using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollarPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            ScoringSystem.Score += starScore;
            transform.position = new Vector3(0, 1000, 0);
        }
    }

    private int starScore = 5;
}
