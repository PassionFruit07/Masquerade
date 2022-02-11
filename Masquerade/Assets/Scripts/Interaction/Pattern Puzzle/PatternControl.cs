using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternControl : MonoBehaviour
{
    static int[] solution = { 2, 1, 4, 3 };
    [SerializeField] int[] input = new int[4];

    void Start()
    {
        IntePattern.Selected += CheckResult;
    }

    // Update is called once per frame

    private void CheckResult(int number)
    {
        input[0] = input[1];
        input[1] = input[2];
        input[2] = input[3];
        input[3] = number;

        //Tirar esto a un boton aparte para realizar el checkeo
        //Falta resetear el puzzle si es incorrecta la respuesta
        if (solution[0] == input[0] && solution[1] == input[1] && solution[2] == input[2] && solution[3] == input[3])
        {
            Debug.Log("Correct Answer");
        }
    }
    private void OnDestroy() //Unsub to avoid reference errors.
    {
        IntePattern.Selected -= CheckResult;
    }
}
