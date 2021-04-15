using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D playerColEnter)
    {
        if(playerColEnter.gameObject.tag == "player")
        {
            print("dentro");
            playeMovement.insideStairs = true;
        }
        else
        {
            playeMovement.insideStairs = false;
        }
    }

    private void OnTriggerExit2D(Collider2D playerColExit)
    {
        if (playerColExit.gameObject.tag == "player")
        {
            print("fuera");
            playeMovement.insideStairs = false;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
