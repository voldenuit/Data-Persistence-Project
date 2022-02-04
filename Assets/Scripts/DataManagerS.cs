using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManagerS : MonoBehaviour
{
    public static DataManagerS instance;
    public string playerName;
    public string bestPlayerName;
    public int bestScore;

    [System.Serializable]
    class SaveData
    {
      public string bestPlayerName;
      public int bestScore;
    }

    public void Save()
    {
        SaveData data = new SaveData();
        data.bestPlayerName = bestPlayerName;
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayerName = data.bestPlayerName;
            bestScore = data.bestScore;
        }
    }

    void Awake()
    {
      if (instance != null)
      {
        Destroy(gameObject);
        return;
      }

      instance = this;
      DontDestroyOnLoad(gameObject);

      Load();
    }
}
