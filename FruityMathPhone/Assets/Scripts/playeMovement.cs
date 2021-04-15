using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeMovement : MonoBehaviour
{
    public float playerSpeed = 10f;
    public static bool insideStairs;
    
    // Start is called before the first frame update
    void Start()
    {
        insideStairs = false;
    }

    // Update is called once per frame
    void Update()
    {
        float pHmovement = Input.GetAxis("Horizontal")*playerSpeed;
        float pVmovement = Input.GetAxis("Vertical")*playerSpeed;

        if (insideStairs)
        {
            transform.Translate(new Vector3(pHmovement, pVmovement, 0f) * Time.deltaTime);
            GetComponent<Rigidbody2D>().gravityScale = 0;
            
        }
        else
        {
            transform.Translate(new Vector3(pHmovement, 0f, 0f) * Time.deltaTime);
            GetComponentInChildren<Rigidbody2D>().gravityScale = 1;
        }
       

     

        
        
    }
}
