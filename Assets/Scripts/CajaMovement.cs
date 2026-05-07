using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{

    public float speed = 2f;
    float initialValue;
    // Start is called before the first frame update
    void Start()
    {
        initialValue = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }

   public void MoveBoxToRandomPosition()
   {
    // para probar hacemos que suba
    Vector3 newPosition = transform.position;
    newPosition.y = initialValue;
    transform.position = newPosition;
   }
}
