using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{

    public float speed = 2f;
    public float speedIncrement = 0.5f;  // Cuánto aumenta la velocidad por cada rebote
    public float maxSpeed = 15f;         // Velocidad máxima para que no sea imposible
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
        Vector3 newPosition = transform.position;
        int randomX = 0;
        randomX = Random.Range(0, 3);
        if (randomX == 0)
        {
            newPosition.x = -3;
        }
        else if (randomX == 1)
        {
            newPosition.x = 0;
        }
        else
        {
            newPosition.x = 3;
        }

        newPosition.y = initialValue;

        transform.position = newPosition;
    }

    // Nuevo método: incrementa la velocidad cada vez que toca el piso
    public void IncreaseSpeed()
    {
        speed = Mathf.Min(speed + speedIncrement, maxSpeed);
        Debug.Log("Velocidad actual de la caja: " + speed);
    }
}
