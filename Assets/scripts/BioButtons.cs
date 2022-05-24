using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BioButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadar()
    {
        SceneManager.LoadScene("ARscene");
    }
    public void goback()
    {
        SceneManager.LoadScene("subjects");
    }
}
