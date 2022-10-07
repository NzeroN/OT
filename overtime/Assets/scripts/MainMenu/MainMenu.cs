using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Menu Navigation")]
    [SerializeField] private SaveSlotsMenu saveSlotsMenu;

    [Header("Menu Buttons")]
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button continueGameButton;
    [SerializeField] private Button loadGameButton;

    [Header("Fading")]

    [SerializeField] private CanvasGroup menu;

    private void Start()
    {
        DisableButtonsDependingOnData();
    }

    private void DisableButtonsDependingOnData()
    {
        if (!DataPersistenceManager.instance.HasGameData())
        {
            continueGameButton.interactable = true;
            loadGameButton.interactable = false;
        }
    }

    public void OnNewGameClicked()
    {
        saveSlotsMenu.ActivateMenu(false);
        this.DeactivateMenu();
        this.menu.alpha -= Time.deltaTime;
    }

    public void OnLoadGameClicked()
    {
        saveSlotsMenu.ActivateMenu(true);
        this.DeactivateMenu();
        this.menu.alpha -= Time.deltaTime;
    }

    public void OnContinueGameClicked()
    {
        DisableMenuButtons();
        // save the game anytime before loading a new scene

        // DataPersistenceManager.instance.SaveGame();

        // load the next scene - which will in turn load the game because of 
        // OnSceneLoaded() in the DataPersistenceManager
        SceneManager.LoadSceneAsync("6thFloor");
        this.menu.alpha -= Time.deltaTime;
    }

    public void OnExitGameClicked()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void OnOptionClicked()
    {
        Debug.Log("Options");
    }

    private void DisableMenuButtons()
    {
        newGameButton.interactable = false;
        continueGameButton.interactable = false;
    }

    public void ActivateMenu()
    {
        this.gameObject.SetActive(true);
        DisableButtonsDependingOnData();
    }

    public void DeactivateMenu()
    {
        this.gameObject.SetActive(false);
    }
}