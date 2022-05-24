using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    public void Awake()
    {
        GameObject[] musicobj = GameObject.FindGameObjectsWithTag("music");
        if(musicobj.Length>1)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(this.gameObject);
    }
   
}
