using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

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
        LoadScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SavePlayerName(string name)
    {
        playerName = name;
    }

    public void UpdateHighScore(int points)
    {
        highScore = points;
        highScoreName = playerName;
        SaveData data = new SaveData();
        data.highestScore = highScore;
        data.highestScoreName = highScoreName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    [System.Serializable]
    class SaveData
    {
        public int highestScore;
        public string highestScoreName;
    }
    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.highestScore = highScore;
        data.highestScoreName = highScoreName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            if(data.highestScore > highScore)
            {
                highScore = data.highestScore;
                highScoreName = data.highestScoreName;
            }
        }
    }
}
