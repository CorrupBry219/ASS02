using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///this is how you quit the game to desktop and stop playing.
        if (Input.GetKeyUp(KeyCode.Escape) == true)
        {
          
            Application.Quit();
        }
    }
}
