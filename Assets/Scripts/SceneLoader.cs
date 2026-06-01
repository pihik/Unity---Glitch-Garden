using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int waitTime = 4;
    int sceneIndex;

    void Start ()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex == 0)
        {
            StartCoroutine(WaitForLoading());
        }
    }
    IEnumerator WaitForLoading()
    {
        yield return new WaitForSeconds(waitTime);
        LoadNextScene();
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
