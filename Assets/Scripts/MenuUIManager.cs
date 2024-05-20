using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    public InputField nameField;
    public Text bestScoreText;
    public Manager manager;
    
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        manager.LoadScore();
        SetHighestScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerName()
    {
        manager.SavePlayerName(nameField.text);
    }
    public void SetHighestScore()
    {
        bestScoreText.text = "Best Score: " + manager.highScoreName + ": " + manager.highScore;
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
}
