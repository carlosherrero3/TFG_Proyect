using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneChangerButton : MonoBehaviour
{
    [Header("Button Settings")]
    public Button button;           // El botón que ejecutará la acción
    public string sceneName;        // Nombre de la escena que se cargará

    void Start()
    {
        if (button != null)
        {
            button.onClick.AddListener(ChangeScene); // Asignar el evento al botón
        }
        else
        {
            Debug.LogWarning("El botón no está asignado en el Inspector.");
        }
    }

    public void ChangeScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName); // Cambiar a la escena deseada
        }
        else
        {
            Debug.LogWarning("El nombre de la escena no está configurado.");
        }
    }
}