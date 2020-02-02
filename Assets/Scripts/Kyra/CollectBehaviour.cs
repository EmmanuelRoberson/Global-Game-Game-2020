using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectBehaviour : MonoBehaviour
{
    public GameEvent eyecollect1;
    public GameEvent eyecollect2;

    public int fakeDestroy = 0;

    private float inputBuffer;


    private void Start()
    {
        inputBuffer = 0;
    }

    private void Update()
    {
        if (fakeDestroy == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                fakeDestroy++;
                eyecollect1.Raise();
                inputBuffer = 0;
            }
        }

        if (fakeDestroy == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space) && inputBuffer >= 2)
            {
                fakeDestroy++;
                eyecollect2.Raise();
            }
        }

        if (fakeDestroy == 2)
        {
            if (Input.GetKey(KeyCode.Backspace))
            {
                StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
            }
        }

        inputBuffer += Time.deltaTime;
    }
    
    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        
        yield return new WaitForSeconds(0);
    }
}
