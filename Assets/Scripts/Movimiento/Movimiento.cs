using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float rapidezCaminar = 4f;
    [SerializeField] private float velInicialDeSalto = 5.0f;
    //[SerializeField] private float alturaSalto = 1.0f;
    [SerializeField] private LayerMask capasSalto;


    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    
    void Start()
    {
     rb= GetComponent<Rigidbody2D>();
     boxCollider= GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }

    public void MoverseEnX(float movimientoX)
    {
        rb.velocity = new Vector2(movimientoX * rapidezCaminar, rb.velocity.y);
    }

    public void Saltar(bool valor)
    {
        if (!boxCollider.IsTouchingLayers())
        {
            return;
        }

        if(valor)
        {
            rb.velocity = new Vector2( rb.velocity.x , velInicialDeSalto);
        }
        

    }
}
