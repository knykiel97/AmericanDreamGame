using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("updateText", 1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void updateText()
    {
        scoreDisplay.GetComponent<Text>().text = "Score: " + Score;
    }

    public static int Score = 0;
    [SerializeField] private Text scoreDisplay;
}
