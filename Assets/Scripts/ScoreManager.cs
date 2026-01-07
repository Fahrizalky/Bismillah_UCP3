using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score;

    void Update()
    {
        // Player masih hidup
        if (GameObject.FindWithTag("Player") != null)
        {
            score += Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
}
