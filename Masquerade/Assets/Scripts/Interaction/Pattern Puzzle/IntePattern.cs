using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntePattern : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Select()
    {
        Debug.Log("You clicked the " + name + " cube");
    }

}
