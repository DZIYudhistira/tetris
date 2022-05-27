using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayGame : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;  

    public void StartGame ()
    {
        StartCoroutine(LoadLevel((SceneManager.GetActiveScene().buildIndex + 1)));
    }
   
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex); 
    }



}
