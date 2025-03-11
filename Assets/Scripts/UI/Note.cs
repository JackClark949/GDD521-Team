using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public GameObject LettersUI;
    bool toggle;
    public Renderer NoteMesh;

    public void openCloseLetter()
    {
        toggle = !toggle;
        if (toggle == false)
        {
            LettersUI.SetActive(false);
            NoteMesh.enabled = true;
        }
        if(toggle == true)
        {
            LettersUI.SetActive(true);
            NoteMesh.enabled = false;
        }
    }
}
