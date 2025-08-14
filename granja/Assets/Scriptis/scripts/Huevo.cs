using UnityEngine;

public class Huevo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instancia.SumarHuevo();
            Destroy(gameObject);  // Esto "rompe" el huevo
        }
    }
}
