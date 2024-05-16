using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int highScore;
    public string highScoreName;
    public string playerName;
    public static Manager Instance;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHighScore(int points)
    {
        highScore = points;
        highScoreName = playerName;
    }
}
