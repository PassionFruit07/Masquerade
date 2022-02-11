using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IntePattern : MonoBehaviour, IInteractable
{
    public static event Action<int, Renderer> Selected = delegate { };

    [SerializeField] Material selectedM;
    MeshRenderer render;
    [SerializeField] int cubeOrder;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    public void Select()
    {
        render.material = selectedM;
        Selected(cubeOrder, render);
        Debug.Log("You clicked the " + name + " cube");
    }

}
