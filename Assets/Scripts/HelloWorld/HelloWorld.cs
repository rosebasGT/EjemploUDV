using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private string msg;
    // Start is called before the first frame update
    void Start()
    {
        //Saludar("Hola");
    }

    public void Saludar()
    {
        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
