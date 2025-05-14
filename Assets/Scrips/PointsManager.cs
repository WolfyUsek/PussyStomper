using System.Drawing;
using TMPro;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textPoints;
    
    [SerializeField] Player player;
    [SerializeField] int finalPoints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        finalPoints = player.getPoints.point;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.getPoints.point != 0)
        {
            finalPoints += player.getPoints.point;
            textPoints.text = finalPoints.ToString();
            player.getPoints.point = 0;
        }
    }
}
