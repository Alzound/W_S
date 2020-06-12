using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Examine : MonoBehaviour
{

    Camera cam; 
    GameObject selectedObj;
    RaycastHit hit;
    public int i = 0; 

    Vector3 originPosition;
    Vector3 originRotation;

    bool examinable;
    bool destruction = false;
    bool theEnd = false;
    RaycastHit Hit;

    public ScrVoiceOverLogic scrVoiceOverLogic;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        examinable = false; 
    }


    // Update is called once per frame
    void Update()
    {
            onSelectedObj();

            turnAround();

            ExitExamination();

    }

    private void onSelectedObj()
    {
        if (Input.GetMouseButtonDown(0) && examinable == false)
        {

            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 8) && hit.transform.tag == "item")
            {

                selectedObj = hit.transform.gameObject;

                originPosition = selectedObj.transform.position;
                originRotation = selectedObj.transform.rotation.eulerAngles;

                selectedObj.transform.position = cam.transform.position + (transform.forward * 3.1f);

                
                Time.timeScale = 0;

                examinable = true;
            }

            else if(Physics.Raycast(ray, out hit, 8) && hit.transform.tag == "KeyObject")
            {
                scrVoiceOverLogic.ReproduceVoiceOver(hit.transform.gameObject.GetComponent<VoiceOverTrigger>().voiceOverIndex);

                selectedObj = hit.transform.gameObject;

                    originPosition = selectedObj.transform.position;
                    originRotation = selectedObj.transform.rotation.eulerAngles;

                    selectedObj.transform.position = cam.transform.position + (transform.forward * 3.1f);


                Time.timeScale = 0; 

                    destruction = true; 
                
            }
            else if (Physics.Raycast(ray, out hit, 8) && hit.transform.tag == "TheEnd")
            {
                Debug.Log("Juasjuas");
              


                selectedObj = hit.transform.gameObject;

                originPosition = selectedObj.transform.position;
                originRotation = selectedObj.transform.rotation.eulerAngles;

                selectedObj.transform.position = cam.transform.position + (transform.forward * 3.1f);


                Time.timeScale = 0;

                theEnd = true; 
            }


        }
    }
    private void turnAround()
    {
        if(Input.GetMouseButton (0) && examinable)
        {
            float rotationsSpeed = 15;

            float xAxis = Input.GetAxis("Mouse X") * rotationsSpeed;
            float yAxis = Input.GetAxis("Mouse Y") * rotationsSpeed;

            selectedObj.transform.Rotate(Vector3.up, -xAxis, Space.World);
            selectedObj.transform.Rotate(Vector3.right, -yAxis, Space.World);
        }
    }

    private void ExitExamination()
    {
        if(Input.GetMouseButtonDown(1) && examinable )
        {
            selectedObj.transform.position = originPosition;
            selectedObj.transform.eulerAngles = originRotation;

            Time.timeScale = 1;
            examinable = false;

           
        }
        else if (Input.GetMouseButtonDown(1)&&destruction==true)
        {
            i++;
            examinable = false;
            Destroy(selectedObj);
            Time.timeScale = 1; 
         
        }
        else if (Input.GetMouseButtonDown(1) && theEnd==true)
        {

            examinable = false;

            Time.timeScale = 1;

            Application.Quit();

        }
    }
}

