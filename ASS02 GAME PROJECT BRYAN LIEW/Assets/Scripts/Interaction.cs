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

    public AudioClip audioClick;
    private AudioSource audioSource;

    void Start()
    {
        crosshair.color = Color.white;
        infoText.text = "Hover over objects to see info here.";
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * reach, Color.blue, 0.01f);

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit objectHit, reach) == true)
        { Debug.Log("Hit a " + objectHit.collider.name);

      
           
            if (objectHit.collider.name == "PFB_Bed" || objectHit.collider.name == "PFB_DiningTable" || objectHit.collider.name == "PFB_Toilet")
            {
               
                crosshair.color = Color.green;
                if (Input.GetKeyDown(KeyCode.Mouse0) == true)
                {
                    
                    audioSource.PlayOneShot(audioClick);
                    switch (objectHit.collider.name)
                    {
                        case "PFB_Bed":
                            infoText.text = "A queen sized bed thats a part of this nicely sized bedroom.";
                        break; 
                        case "PFB_DiningTable":
                            infoText.text = "A Kitchen Dining table for the whole family to enjoy a meal.";
                        break;
                        case "PFB_Toilet":
                            infoText.text = "A neccesary bathroom toilet to dispose of excretment.";
                        break;
                    }


                }
            }
            

            else
            {
                
                crosshair.color = Color.white;
                infoText.text = "Hover over objects to see info there.";
            }
        }
    }

}
