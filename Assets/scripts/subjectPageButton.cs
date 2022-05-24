using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class subjectPageButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Bac()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Bio()
    {
        SceneManager.LoadScene("Biology");
    }

    public void Hist()
    {
        SceneManager.LoadScene("History");
    }
    public void Phy()
    {
        SceneManager.LoadScene("Physics");
    }

    public void Geo()
    {
        SceneManager.LoadScene("Geography");
    }
}
