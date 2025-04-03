using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class etacionamiento : MonoBehaviour
{
    public int hora;
    bool estaAbierto;
    // Start is called before the first frame update
    void Start()
    {
        if (hora >= 0 || hora > 24)
        {
            Debug.Log("ha ingresado una hora incorrecta");
            return;
        }
        else if (hora >= 10 && hora < 18) 
        {
            estaAbierto = true;
        }else
        {
            estaAbierto = false;
        }
        Debug.Log("el estacionamiento esta abierto" + estaAbierto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
