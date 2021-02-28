using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public void CambiarEscena(string nombre)
    {
        print("Cambiando a la escena " + nombre);
    }
    public void Salir()
    {
        print("Saliendo del juego");
    }

}

