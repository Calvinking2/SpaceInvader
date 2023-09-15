using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    public GameObject Pause;
    void Start()
    {
        isPaused = false;
        ResumeGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        Pause.SetActive(true);
        isPaused = true;    
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        Pause.SetActive(false); 
        isPaused = false;
    }
}
