using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu, startMenu;
    // Update is called once per frame

    private IEnumerator Start()
    {
        startMenu.SetActive(true);
         this.enabled = false; // Disable us while waiting
         // Wait for input
         while (!Input.anyKey)
         {
             yield return null;
         }
         
         this.enabled = true; // Enable us now
         startMenu.SetActive(false);
     }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void  Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    } void Pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    } public void Exit() {
        Debug.Log("Now Exiting...");
        Application.Quit();
    }
}


/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    public static bool isPaused = false;
    public GameObject pauseMenu;

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void openMenu() {

    } public void  Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    } public void Pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    } public void Exit() {

    }
}
 */