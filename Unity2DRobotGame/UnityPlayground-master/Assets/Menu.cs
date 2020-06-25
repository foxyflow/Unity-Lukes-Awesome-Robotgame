using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject MenuPanel;

    private void Start()
    {
        MenuPanel.gameObject.SetActive(false);
    }

    public void Button1()
    {
        SceneManager.LoadScene("level4Playground");
    }
    public void Button2()
    {
        SceneManager.LoadScene("level5");
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}
