using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Si usas TextMeshPro (recomendado)
// using UnityEngine.UI; // Descomenta esta línea y comenta la de arriba si usas UI Text clásico

public class TiempoContador : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo; // Arrastrá el Text de la UI aquí en el Inspector
    // public Text textoTiempo;         // Usá esta línea si usas UI Text clásico

    private float tiempoTranscurrido = 0f;
    private bool corriendo = true;

    void Update()
    {
        if (corriendo)
        {
            tiempoTranscurrido += Time.deltaTime;
            textoTiempo.text = tiempoTranscurrido.ToString("F2") + "s";
        }
    }

    // Llamá este método cuando el player muere para pausar el contador
    public void PausarContador()
    {
        corriendo = false;
    }
}
