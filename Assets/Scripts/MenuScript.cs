using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject creditMenu;
    [SerializeField] GameObject instructionsMenu;
    SpawnAnimals SpawninAnim;

    private void Start()
    {
        GameObject SpawnManager = GameObject.FindGameObjectWithTag("SpawnAnimals");
        SpawninAnim = SpawnManager.GetComponent<SpawnAnimals>();
        SpawninAnim.enabled = false;
    }
    public void StartGame()
    {
        //SceneManager.LoadScene("Level1");
        instructionsMenu.SetActive(false);
        SpawninAnim.enabled = true;
    }
    public void ShowInstruct()
    {
        mainMenu.SetActive(false);
        instructionsMenu.SetActive(true);
        SpawninAnim.enabled = false;
    }
    public void ShowCredits()
    {
        mainMenu.SetActive(false);
        creditMenu.SetActive(true);
        SpawninAnim.enabled = false;
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        creditMenu.SetActive(false);
        SpawninAnim.enabled = false;
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
