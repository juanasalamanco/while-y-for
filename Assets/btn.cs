using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void EscribirEnConsola()
    {
        int contador = 0;
        while (contador < 5)
        {
            Debug.Log("¡Hola mundo!");
            contador++;
        }
      
    }
}
