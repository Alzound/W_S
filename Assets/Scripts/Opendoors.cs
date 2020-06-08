using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoors : MonoBehaviour
{
    public int opc=5;
    public int rot=90; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Options();
    }

    void Options()
    {
        if(gameObject.tag== "Door1" && GameObject.Find("Main Camera").GetComponent<Examine>().i == 1 )
        {
       
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (gameObject.tag == "Door2" && GameObject.Find("Main Camera").GetComponent<Examine>().i == 2)
        {
   
            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else if (gameObject.tag == "Door3" && GameObject.Find("Main Camera").GetComponent<Examine>().i == 3)
        {
  
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (gameObject.tag == "Door4" && GameObject.Find("Main Camera").GetComponent<Examine>().i == 4)
        {

            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else if (gameObject.tag == "Door5" && GameObject.Find("Main Camera").GetComponent<Examine>().i == 5)
        {

            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
