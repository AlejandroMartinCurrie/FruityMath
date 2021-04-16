using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxTrigger : MonoBehaviour
{

    public GameObject letterText;
    public GameObject grabPosition;
    private bool textActive;
    public static bool objectGrabed;



    private void OnTriggerEnter2D(Collider2D playerColEnter)
    {
        if (playerColEnter.gameObject.tag == "player")
        {
            letterText.SetActive(true);
            textActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D playerExit)
    {
        if(playerExit.tag =="player")
        {
            letterText.SetActive(false);
            textActive = false;
        }
    }




    public void GrabObject()
    {
        if (textActive == true && Input.GetKeyDown(KeyCode.R))
        {
            objectGrabed = true;
            print("hello");
        }
        else if(objectGrabed == true && Input.GetKeyDown(KeyCode.E))
        {
            objectGrabed = false;
        }
    }

    public void ChangePosition()
    {
        transform.position = grabPosition.transform.position;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }





    // Update is called once per frame
    void Update()
    {
        GrabObject();
        if(objectGrabed == true)
        {
            ChangePosition();
        }
    }
}
