using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PauseGame(){
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void RestartGame(){
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    
    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
}
