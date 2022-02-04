using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManagerS : MonoBehaviour
{
    public InputField playerNameInputField;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    public void SetName()
    {
      DataManagerS.instance.playerName = playerNameInputField.text;
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
