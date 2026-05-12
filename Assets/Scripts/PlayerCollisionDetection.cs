using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    public TiempoContador tiempoContador; // Arrastrá el GameObject del contador aquí

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Caja"))
        {
            tiempoContador.PausarContador(); // Pausa el tiempo antes de destruirse
            Destroy(gameObject);
        }
    }
}
