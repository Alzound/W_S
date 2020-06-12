using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio; 
using UnityEngine;

public class Opendoors : MonoBehaviour
{
   
    AudioSource audioData;
    public GameObject trigger; 


    // Start is called before the first frame update
    void Awake()
    {

        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Options();
        theEnd();
    }

    void Options()
    {
        if(gameObject.tag == "Door1" && GameObject.Find("Main Camera").GetComponent<Examine>().i == 1 )
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

    void theEnd()
    {
        if (this.gameObject.tag == "Nightmare" && trigger == true && gameObject.tag == "Door5")
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
