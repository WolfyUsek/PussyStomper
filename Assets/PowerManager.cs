using UnityEngine;

public class PowerManager : MonoBehaviour
{
    public float countDown, countDown2, resetpowerUpCoolDown, randomXd;
    public bool isInmortal, isConting;
    public GameObject wallInmortality, powerUpObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        powerUpObject.SetActive(true);
        wallInmortality.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInmortal && powerUpObject.active == false)
        {
            wallInmortality.SetActive(true);
            countDown += Time.deltaTime;
            
            if (countDown > 5) 
            {
                countDown = 0;
                isInmortal = false;
                wallInmortality.SetActive(false);
            }
        }
       else if (isInmortal == false && powerUpObject.active == false)
        {

            resetpowerUpCoolDown =  Random.Range(10, randomXd);
            
            countDown2 += Time.deltaTime;
            if (countDown2 > resetpowerUpCoolDown) 
            {
                powerUpObject.SetActive(true);
                countDown2 = 0;
            }
        }


    }
}
