using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interaction : MonoBehaviour
{
        // Declare variables
    public float reach = 3f;
    public Image crosshair;
    public Text infoText;


    void Start()
    {
        crosshair.color = Color.white;
        infoText.text = "Hover over objects to see info here.";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * reach, Color.blue, 0.01f);

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit objectHit, reach) == true)
        { Debug.Log("Hit a " + objectHit.collider.name);

      
           
            if (objectHit.collider.name == "PFB_Bed" || objectHit.collider.name == "PFB_DiningTable" || objectHit.collider.name == "PFB_Toilet")
            {
                Debug.Log("I hit the Queen sized bed!");
                crosshair.color = Color.green;
                infoText.text = objectHit.collider.name;
            }
            else
            {
                Debug.Log("where is that kitchen Queen sized bed?");
                crosshair.color = Color.white;
                infoText.text = "Hover over objects to see info there.";
            }
        }
    }
}
