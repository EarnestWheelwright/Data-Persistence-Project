using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    public InputField nameField;
    public Manager manager;
    
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPlayerName()
    {
        manager.playerName = nameField.text;
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
