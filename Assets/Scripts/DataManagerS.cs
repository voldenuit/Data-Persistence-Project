using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManagerS : MonoBehaviour
{
    public static DataManagerS instance;
    public string playerName;
    public int score;

    void Awake()
    {
      if (instance != null)
      {
        Destroy(gameObject);
        return;
      }

      instance = this;
      DontDestroyOnLoad(gameObject);
    }
}
