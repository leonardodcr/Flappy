using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static bool gameOver = false;
    public static int scoreValue = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            score.text = $"Score: {scoreValue}";
            return;
        }

        score.text = $"Game over! Score: {scoreValue}";
    }
}