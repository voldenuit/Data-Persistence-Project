using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManagerS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
      SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
      #if UNITY_EDITOR
      EditorApplication.ExitPlaymode();
      #else
      Application.Quit();
      #endif
    }


}
