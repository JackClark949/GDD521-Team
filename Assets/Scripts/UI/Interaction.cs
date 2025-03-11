using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float interactionDistance;
    public GameObject InteractionText;
    public LayerMask interactionLayers;

    private void FixedUpdate()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance, interactionLayers))
        {
            if(hit.collider.gameObject.GetComponent<Note>())
            {
                InteractionText.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Note>().openCloseLetter();
                }
            }
            else
            {
                InteractionText.SetActive(false);
            }
        }
        else
        {
            InteractionText.SetActive(false);
        }
    }
}
