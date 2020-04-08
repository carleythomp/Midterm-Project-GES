using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject creditMenu;
    [SerializeField] GameObject instructionsMenu;


    private void Start()
    {
        GameObject SpawnManager = GameObject.FindGameObjectWithTag("SpawnAnimals");

    }
    public void StartGame()
    {
        //SceneManager.LoadScene("Level1");
        instructionsMenu.SetActive(false);
       
    }
    public void ShowInstruct()
    {
        mainMenu.SetActive(false);
        instructionsMenu.SetActive(true);
    }
    public void ShowCredits()
    {
        mainMenu.SetActive(false);
        creditMenu.SetActive(true);

    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        creditMenu.SetActive(false);
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
