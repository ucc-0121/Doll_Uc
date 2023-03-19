using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("IPHONE");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("LINE");
    }
    public void RetryGame()
    {
        SceneManager.LoadScene("Mainpage");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Mainpage");
    }
    public void Show_all()
    {
        SceneManager.LoadScene("Show_all");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
