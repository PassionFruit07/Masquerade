using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IntePattern : MonoBehaviour, IInteractable
{
    public static event Action<int> Selected = delegate { };

    [SerializeField] Material defaulfM, selectedM;
    MeshRenderer render;
    [SerializeField] int cubeOrder;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Select()
    {
        render.material = selectedM;
        Selected(cubeOrder);
        Debug.Log("You clicked the " + name + " cube");
    }

}
