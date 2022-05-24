using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Vrswipe : MonoBehaviour
{
    private Vector3 fp;
    private Vector3 lp;
    private float dragDistance;
    // Start is called before the first frame update
    void Start()
    {
        dragDistance=Screen.height*15/100;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Began)
            {
                fp=touch.position;
                lp=touch.position;
            }
            else if (touch.phase==TouchPhase.Moved)
            {
                lp=touch.position;
            }
            else if (touch.phase==TouchPhase.Ended)
            {
                lp=touch.position;
                if(Mathf.Abs(lp.x-fp.x)>dragDistance || Mathf.Abs(lp.y-fp.y)>dragDistance)
                {
                    if(Mathf.Abs(lp.x-fp.x)> Mathf.Abs(lp.y-fp.y))
                    {
                        if(lp.x>fp.x)
                        {
                            //right swip
                            SceneManager.LoadScene("Biology");
                        }
                        else
                        {
                            //left swip
                            SceneManager.LoadScene("Biology");
                        }
                    }
                }
            }
        }
    }
}
