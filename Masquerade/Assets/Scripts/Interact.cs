using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour, iInteractuable
{
    void iInteractuable.Select()
    {
        Debug.Log("Funcionó mi rey");
    }
}
