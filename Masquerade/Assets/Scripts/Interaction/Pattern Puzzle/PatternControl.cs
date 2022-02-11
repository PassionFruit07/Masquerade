using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternControl : MonoBehaviour
{
    static int[] solution = { 2, 1, 4, 3 };
    int selectionCount;

    [SerializeField] int[] input = new int[4];
    [SerializeField] Material defaulfM;
    Renderer[] renders = new Renderer[4];

    void Start()
    {
        selectionCount = 0;
        IntePattern.Selected += CheckResult;
    }

    // Update is called once per frame

    private void CheckResult(int number, Renderer render)
    {
        input[0] = input[1];
        input[1] = input[2];
        input[2] = input[3];
        input[3] = number;

        renders[0] = renders[1];
        renders[1] = renders[2];
        renders[2] = renders[3];
        renders[3] = render;
        selectionCount++;


        if(selectionCount == 4)
        {
            if (solution[0] == input[0] && solution[1] == input[1] && solution[2] == input[2] && solution[3] == input[3])
            {
                Debug.Log("Correct Answer");
            }
            else
            {
                Debug.Log("you're wrong, try again");
                selectionCount = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = 0;
                    renders[i].material = defaulfM;
                    renders[i] = null;
                }
                /*foreach(Renderer rend in renders)
                {
                    rend.material = defaulfM;
                }*/
            }
        }
        
    }
    private void OnDestroy() //Unsub to avoid reference errors.
    {
        IntePattern.Selected -= CheckResult;
    }
}
