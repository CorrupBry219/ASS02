using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interaction : MonoBehaviour
{
        // Declare variables
    public float reach = 3f;
    public Image Crosshair;
    public Text infoText;

    public AudioClip audioClick;
    private AudioSource audioSource;

    void Start()
    {
        Crosshair.color = Color.white;
        infoText.text = "Hover over objects to see info here.";
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
