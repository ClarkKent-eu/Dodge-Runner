using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeatCounter : MonoBehaviour
{
    private int Death;
    public TextMeshProUGUI DeathCounter;


    // Start is called before the first frame update
    void Start()
    {
        


 
        Death = 0;
        DeathCounter.text = "DeathCounter:" + Death;

    
        
    }

    private void UpdateDeath(int DeathToAdd)
    {

        Death += DeathToAdd;
        DeathCounter.text = "Score: " + Death;



    }




    // Update is called once per frame
    void Update()
    {









        
    }
}
