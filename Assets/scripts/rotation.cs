using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 movement;
    public int x,y,z;
    public GameObject itemToRotate;
    void Start()
    {
        movement=new Vector3(x,y,z);
    }

    // Update is called once per frame
    private void Update()
    {   
		if (Input.GetKeyDown(KeyCode.B))
		        {        
		            StartCoroutine(RotateObject());
		        }      
		 
    }  
IEnumerator RotateObject()
{
        float moveSpeed = 10f;        
        Quaternion endingAngle = Quaternion.Euler(new Vector3(0, 180, 0));        
        while (Vector3.Distance(itemToRotate.transform.rotation.eulerAngles, endingAngle.eulerAngles) > 0.01f)    
        {
            itemToRotate.transform.rotation = Quaternion.RotateTowards(itemToRotate.transform.rotation, endingAngle, moveSpeed * Time.deltaTime);           
            yield return null;
        }        
        itemToRotate.transform.rotation = endingAngle;
}
}
