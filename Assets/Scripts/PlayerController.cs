using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float posicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.D) )
       {
        if(transform.position.x < posicionInicial + 3f){
            transform.Translate(3,0,0);
        }
        
       } 
       else if(Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.A) )
       {
         if(transform.position.x > posicionInicial - 3f){
        transform.Translate(-3,0,0);
         }
       }

    }
}
