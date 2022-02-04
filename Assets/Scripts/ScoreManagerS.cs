using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadNameAndScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNameAndScore()
    {
      if (!(DataManagerS.instance.bestScore == 0))
      {
      gameObject.GetComponent<Text>().text = "Best Score: " + DataManagerS.instance.bestPlayerName + ": " + DataManagerS.instance.bestScore;
      }
    }

}
