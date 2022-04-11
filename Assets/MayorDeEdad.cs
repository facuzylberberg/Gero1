using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayorDeEdad : MonoBehaviour
{
    public int edadusuario;
    public Text miTexto;

    // Start is called before the first frame update
    void Start()
    {
        if (edadusuario >= 18)
        {
            miTexto.text = "Usted es mayor de edad";
            Debug.Log("Usted es mayor de edad");

        }

        else
        {
            miTexto.text = "Usted no es mayor de edad";
            Debug.Log("Usted no es mayor de edad");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
