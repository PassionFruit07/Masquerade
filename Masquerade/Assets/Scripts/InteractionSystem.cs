using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    [SerializeField] float maxRange = 3.5f;
    //[SerializeField] LayerMask mask;
    //[SerializeField] new Transform camera;


    void Update()
    {
        Selecting();
    }
    void Selecting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, maxRange/*, mask*/)) //No borrar, en caso de revisar mascaras
            {
                var selectable = hit.transform;
                iInteractuable selectableCode = selectable.gameObject.GetComponent<iInteractuable>();
                if (selectableCode != null)
                {
                    selectableCode.Select();
                }
            }
        }
    }
}
