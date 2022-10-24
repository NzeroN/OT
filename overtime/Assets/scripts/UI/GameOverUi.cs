using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOverUi : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Menu Buttons")]
    [SerializeField] private Button retryButton;
    [SerializeField] private Button mainMenuButton;

    public void OnRetryClicked()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void OnMainMenuClicked()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
