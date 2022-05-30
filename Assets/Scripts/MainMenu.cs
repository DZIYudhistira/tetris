using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewGamePopout : MonoBehaviour
{

    public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   

    public void QuitGame2 ()
    {
        Debug.Log("Succesfully Quit");
        Application.Quit(); 

    }

}
