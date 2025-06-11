using UnityEngine;

public class ColisionPowerUpInmortal : MonoBehaviour
{
    public PowerManager PowerManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PowerManager.isInmortal = true;
            gameObject.SetActive(false);
        }
    }
}
