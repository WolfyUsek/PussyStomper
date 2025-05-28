using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public GameObject basePrefab;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public ScoreTextAnimator scoreTextAnimator;
    private void Update()
    {
        if (score == 1)
        {
            basePrefab.SetActive(false);
        }
    }
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddPoint(int amount = 1)
    {
        score += amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
            scoreTextAnimator.Animate();

        }
    }
}
