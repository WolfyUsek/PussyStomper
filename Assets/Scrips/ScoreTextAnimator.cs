using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScoreTextAnimator : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void Animate()
    {
        StartCoroutine(Bounce());
    }

    IEnumerator Bounce()
    {
        Vector3 originalScale = scoreText.transform.localScale;
        scoreText.transform.localScale = originalScale * 1.2f;

        yield return new WaitForSeconds(0.1f);

        scoreText.transform.localScale = originalScale;
    }
}
