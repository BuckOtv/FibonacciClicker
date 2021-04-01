using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor : MonoBehaviour
{
    //Animator voor de cursorclick animatie
    public Animator animatorclick;
    private void Start()
    {
        //Zet de cursor niet visible
        Cursor.visible = false;
    }
    private void Update()
    {
        //Maakt een vector2 cursorpositie waarvan de muispositie op het scherm zit
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Zet de positie van dit gameobject om naar de positie van de muis
        transform.position = cursorPos;

        //Als je de linkermuisknop indrukt, dan speelt hij de click animatie af.
        if(Input.GetMouseButtonDown(0))
        {
            animatorclick.Play("Click");
        }
    }
}
