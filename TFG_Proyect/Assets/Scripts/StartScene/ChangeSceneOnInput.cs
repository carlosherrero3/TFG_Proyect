using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnInput : MonoBehaviour
{
    public string sceneToLoad = "Menú Principal"; //Nombre de la escena a la que cambiar.

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0)) //Comprueba si el usuario ha pulsado una tecla o ha hecho click
        {
            SceneManager.LoadScene(sceneToLoad); //Carga la escena
        }
    }
}
