using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System.Collections.Generic;

public class ScoreTextAnimator : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public List<TextMeshProUGUI> scoreText2;

    public void Animate()
    {
        //StartCoroutine(Bounce());
        StartCoroutine(Bounce2());
    }

    IEnumerator Bounce()
    {
        Vector3 originalScale = scoreText.transform.localScale;
        scoreText.transform.localScale = originalScale * 1.2f;

        yield return new WaitForSeconds(0.1f);

        scoreText.transform.localScale = originalScale;
    }

    IEnumerator Bounce2()
    {
        foreach (TextMeshProUGUI text in scoreText2)
        {
            Vector3 originalScale = text.transform.localScale;
            text.transform.localScale = originalScale * 1.2f;

            yield return new WaitForSeconds(0.1f);

            text.transform.localScale = originalScale;
        }
    }
}
