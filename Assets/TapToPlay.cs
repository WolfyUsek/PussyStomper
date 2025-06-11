using Unity.VisualScripting;
using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    public Animator IsTapped, isTappedOptions;
    public GameObject videgame;
    public bool isTappedOptionsBool= false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (isTappedOptionsBool)
        {
            isTappedOptions.SetBool("IsTaped", true);
        }
        else
        {

            isTappedOptions.SetBool("IsTaped", false);
        }
    }
    

   public void MainIsPress()
    {
        IsTapped.SetBool("IsTapped", true);
        videgame.SetActive(true);
    }

    public void OptionsIsPress()
    {
        isTappedOptionsBool = !isTappedOptionsBool;
    }
}
