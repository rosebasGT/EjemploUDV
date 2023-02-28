using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCuadrado : MonoBehaviour
{
    private HelloWorld hw;
    // Start is called before the first frame update
    void Start()
    {
        hw = GetComponent<HelloWorld>();
        hw.Saludar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
