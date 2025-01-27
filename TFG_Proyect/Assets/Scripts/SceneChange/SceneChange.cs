using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Esta variable te permite asignar la escena que deseas cargar en el Inspector de Unity.
    public string sceneToLoad;

    // Esta funci�n se puede llamar para cambiar de escena cuando sea necesario.
    public void ChangeScene()
    {
        // Aseg�rate de que la escena est� cargada correctamente en las Build Settings.
        SceneManager.LoadScene(sceneToLoad);
    }

    // Si quieres cambiar de escena cuando presionas una tecla espec�fica, como la tecla 'C', puedes usar este c�digo.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))  // Puedes cambiar la tecla a la que prefieras.
        {
            ChangeScene();
        }
    }
}
