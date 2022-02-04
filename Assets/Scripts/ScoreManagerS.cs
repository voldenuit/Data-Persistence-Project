using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadName()
    {
      if (!(DataManagerS.instance.score == 0))
      {
      gameObject.GetComponent<Text>().text = "Best Score: " + DataManagerS.instance.playerName + ": " + DataManagerS.instance.score;
      }
    }

}
