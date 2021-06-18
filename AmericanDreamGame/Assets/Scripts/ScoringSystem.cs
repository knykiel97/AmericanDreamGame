using UnityEngine;
using UnityEngine.UI;

/*
 * Stores current score and updates corresponding GUI element
 */
public class ScoringSystem : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("UpdateText", 1f, 0.1f);
    }

    private void UpdateText()
    {
        scoreDisplay.GetComponent<Text>().text = "Score: " + Score;
    }

    public static int Score = 0;
    [SerializeField] private Text scoreDisplay;
}
