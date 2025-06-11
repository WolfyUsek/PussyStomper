
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player, pantallaLose, videogame;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pantallaLose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.active == false && videogame.active == true)
        {
            pantallaLose.SetActive(true);
            if (Input.GetKeyDown(KeyCode.W))
            {
                SceneManager.LoadScene(0);
                
            }
            if (Input.touchCount != 0)
            {
                SceneManager.LoadScene(0);
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);

        }
    }

    // PlayerPrefs.Clear();
}
