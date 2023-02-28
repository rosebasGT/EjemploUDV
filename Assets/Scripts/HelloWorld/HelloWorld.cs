using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Saludar("HOLA");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Saludar(string saludo)
    {
        Debug.Log(saludo);
    }
}
