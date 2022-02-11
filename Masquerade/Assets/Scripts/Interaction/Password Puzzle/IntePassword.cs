using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IntePassword : MonoBehaviour, IInteractable
{
    public static event Action<string, int> Rotated = delegate { };

    private bool canCoroutine;
    private int numShown;
    [SerializeField] int startNum;
    [SerializeField] float waitRotate;

    private void Start()
    {
        canCoroutine = true;
        numShown = startNum;
    }
    public void Select()
    {
        if (canCoroutine) StartCoroutine("RotateWheel"); //puedo escuchar a Serna quejarse
        Debug.Log("action");
    }

    private IEnumerator RotateWheel()
    {
        canCoroutine = false; //solo un safe-fail porque I have trust issues
        
        //Esta rotacion podria ser un Lerp but I hate those so yeah
        // Y no se que come mas recursos, demas que el Lerp
        // Les dejo esa tarea tesos de videojuegos <3
        for (int i = 0; i <= 11; i++)
        {
            transform.Rotate(0f, -3f, 0f);
            yield return new WaitForSeconds(waitRotate);
        }

        canCoroutine = true;
        numShown += 1;
        if (numShown > 9) numShown = 0;

        Rotated(name, numShown);
    }
}
