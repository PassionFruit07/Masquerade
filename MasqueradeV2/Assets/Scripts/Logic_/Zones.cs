using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zones : MonoBehaviour
{
    [SerializeField] string name;
    [SerializeField] Text text;

    void Start()
    {
        Disappear();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.text = name;
            Show();
        }
    }

    void Show()
    {
        text.enabled = true;
        Invoke("Disappear", 1.5f);
    }
    void Disappear()
    {
        text.enabled = false;
    }
}
