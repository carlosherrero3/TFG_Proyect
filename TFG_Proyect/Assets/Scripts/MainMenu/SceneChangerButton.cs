using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneChangerButton : MonoBehaviour
{
    [Header("Button Settings")]
    public Button button;           // El bot�n que ejecutar� la acci�n
    public string sceneName;        // Nombre de la escena que se cargar�

    void Start()
    {
        if (button != null)
        {
            button.onClick.AddListener(ChangeScene); // Asignar el evento al bot�n
        }
        else
        {
            Debug.LogWarning("El bot�n no est� asignado en el Inspector.");
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
            Debug.LogWarning("El nombre de la escena no est� configurado.");
        }
    }
}