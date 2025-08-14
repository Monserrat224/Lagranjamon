using UnityEngine;

public class RompeHuevos : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Detecta colisión con el jugador
        {
            GameManager.instancia.SumarHuevo();  // Suma huevo en GameManager
            Destroy(gameObject);  // Destruye el huevo
        }
    }
}
