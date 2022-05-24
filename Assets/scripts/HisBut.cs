using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HisBut : MonoBehaviour
{
    public void loadVR()
    {
        SceneManager.LoadScene("VRScene");
    }
    public void goback()
    {
        SceneManager.LoadScene("subjects");
    }
}
