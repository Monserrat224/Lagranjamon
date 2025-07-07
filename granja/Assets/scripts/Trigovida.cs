using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class Trigovida : MonoBehaviour
{
    public int Estado = 0;
    public Animator animator;
    public float tiempo = 5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(CambiarEstado());
    }

    private IEnumerator CambiarEstado()
    {
        while(Estado < 4)
        {
            animator.SetInteger("Estado", Estado);
            Estado++;
            yield return new WaitForSeconds(tiempo);
        }

    }

   
}
