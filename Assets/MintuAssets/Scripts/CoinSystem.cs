using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{

    public static int coinStock = 0;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCoin()
    {
        coinStock++;
        Debug.Log(coinStock);
        

    }

    private void OnTriggerEnter(Collider other)
    {
        
        
        if(other.tag == "Player")
        {

            M_EventManager.mintuEvent += addCoin;
            this.gameObject.SetActive(false);
           // M_EventManager.mintuEvent.

        }


    }

}
