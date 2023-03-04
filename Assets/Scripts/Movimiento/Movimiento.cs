using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    [SerializeField] private float rapidezCaminar = 4f;
    [SerializeField] private float alturaSalto = 2.0f;
    [SerializeField] private LayerMask capasSalto;
    //Controlamos el numero de saltos que tendra
    [SerializeField] private int numeroSalto = 3;

    
    private Rigidbody2D rb;
    private BoxCollider2D boxcollider;
    //Variable para la velocidad inicia del salto que se calcula en Start
    private float velInicialDeSalto;
    //Nos sirve para validar los saltos que tendremos
    private int validacionSalto;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxcollider = GetComponent<BoxCollider2D>();
        //Calaculamos la gravedad
        float gravedad = Physics2D.gravity.y * rb.gravityScale;
        //Calculamos la velocidad que tendra el salto
        velInicialDeSalto = Mathf.Sqrt(2 * alturaSalto * Mathf.Abs(gravedad));
        // indicamos que la validacionSalto sea igual a numero de saltos que tengamos definidos
        validacionSalto = numeroSalto;
    }

    void Update()
    {

    }

    public void MoverseEnX(float movimientoX)
    {
        // nos movemos en X
        rb.velocity = new Vector2(movimientoX * rapidezCaminar, rb.velocity.y);
    }

    public void Saltar(bool valor)
    {
        //Indicamos que nuestro jugador toque la plataforma y validamos que la cantidad de saltos sea mayor a 0
        if (valor && validacionSalto > 0)
        {

            if (!float.IsNaN(velInicialDeSalto) && velInicialDeSalto > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, velInicialDeSalto);
            }
            // le restamos un salto
            validacionSalto--;

        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.layer == LayerMask.NameToLayer("Plataforma"))
        {
            validacionSalto = numeroSalto;

        }
    }

}
