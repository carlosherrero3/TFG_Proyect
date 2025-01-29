using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainMenuPanel; // Panel con los botones principales (Jugar, Cargar Partida, etc.)
    public GameObject loadGamePanel; // Panel para cargar partidas guardadas
    public GameObject optionsPanel;  // Panel de opciones
    public GameObject newGameConfirmationPanel; // Panel de confirmación para iniciar nueva partida

    [Header("Saved Data")]
    public string defaultScene = "Level1"; // Nombre de la escena del Nivel 1
    public string savedGameSceneKey = "SavedScene"; // Clave para el PlayerPrefs de la escena guardada

    public void ShowLoadGamePanel()
    {
        SetActivePanel(loadGamePanel);
    }

    public void ShowOptionsPanel()
    {
        SetActivePanel(optionsPanel);
    }

    public void ShowNewGameConfirmation()
    {
        SetActivePanel(newGameConfirmationPanel);
    }

    public void StartGame()
    {
        string savedScene = PlayerPrefs.GetString(savedGameSceneKey, "");
        if (!string.IsNullOrEmpty(savedScene))
        {
            SceneManager.LoadScene(savedScene); // Cargar la escena guardada
        }
        else
        {
            StartNewGame(); // No hay partida guardada, iniciar nueva partida
        }
    }

    public void StartNewGame()
    {
        PlayerPrefs.DeleteKey(savedGameSceneKey); // Limpiar datos guardados anteriores
        SceneManager.LoadScene(defaultScene);    // Cargar la primera escena
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SetActivePanel(mainMenuPanel);
    }

    private void SetActivePanel(GameObject activePanel)
    {
        mainMenuPanel.SetActive(false);
        loadGamePanel.SetActive(false);
        optionsPanel.SetActive(false);
        newGameConfirmationPanel.SetActive(false);

        if (activePanel != null)
        {
            activePanel.SetActive(true);
        }
    }
}