using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public GameObject basePrefab;
    public int score = 0;
    public int highScore = 0;
    [SerializeField] bool isRecordRun;
    public TextMeshProUGUI scoreText, highScoreText;
    public ScoreTextAnimator scoreTextAnimator;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("High Score", 0);
        UpdateScoreUI();
    }

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

        if(score >= highScore)
        {
            highScore = score;
            isRecordRun = true;
        }
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
            scoreTextAnimator.Animate();
        }

        if(highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore;
        }
    }

    private void OnDestroy()
    {
        if (isRecordRun)
        {
            PlayerPrefs.SetInt("High Score", score);
        }
    }
}
