using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class blockRotate : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction Rotate;
    openDrawer openDrawer;
    public GameObject openDrawerr;
    private bool blockRotation = false;



    public GameObject rotatePiece2;

    public Quaternion[] rotations;
    public Quaternion[] rotations2;
    private int currentRotation = 0;
    private int currentRotation2 = 0;





    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        Rotate = playerInput.actions.FindAction("Rotate");
        openDrawer = openDrawerr.GetComponent<openDrawer>();


        rotations = new Quaternion[]
        {
            Quaternion.Euler(45, 0, 0),
            Quaternion.Euler(75, 0, 0),
            Quaternion.Euler(52, 0, 0)


        };

        rotations2 = new Quaternion[]
        {
            Quaternion.Euler(60, 0, 0),
            Quaternion.Euler(30, 0, 0),
            Quaternion.Euler(85, 0, 0)

        };

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            blockRotation = true;


        }
    }

    private void OnTriggerExit(Collider other)
    {
        blockRotation = false;

    }


    public void RotateBlock(InputAction.CallbackContext context)
    {
        if (blockRotation == true && context.performed)
        {

            currentRotation = (currentRotation + 1) % rotations.Length;
            gameObject.transform.rotation = rotations[currentRotation];
            Debug.Log("Rotated");

            currentRotation2 = (currentRotation2 + 1) % rotations.Length;
            rotatePiece2.transform.rotation = rotations2[currentRotation2];
            Debug.Log("Rotated 2");

            float xRotation = gameObject.transform.rotation.eulerAngles.x;
            float xRotation2 = rotatePiece2.transform.rotation.eulerAngles.x;

            if (Mathf.Abs(xRotation - 75f) < 0.1f && Mathf.Abs(xRotation2 - 30f) < 0.1f)
            {
                openDrawer.playAnim();
            }




        }






    }




}


