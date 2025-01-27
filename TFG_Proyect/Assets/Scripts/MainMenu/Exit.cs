using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitGame ()
    {
        Application.Quit(); //Para salir del juego
        Debug.Log("Ha salido del juego ");
    }
}
