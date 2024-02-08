using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{   
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject panel2;
    private void Start()
    {
        panel.SetActive(false);
        panel2.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void PanelOpen()
    {
        panel.SetActive(true);
    }
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
    public void PanelOpen2()
    {
        panel2.SetActive(true);
    }
    public void ClosePanel2()
    {
        panel2.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
