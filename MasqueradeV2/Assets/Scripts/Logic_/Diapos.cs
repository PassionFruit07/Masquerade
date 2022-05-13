using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diapos : MonoBehaviour
{
    [SerializeField] GameObject back, next;
    [SerializeField] GameObject[] diapos;
    int currentPage;

    void Start()
    {
        next.SetActive(false);
        back.SetActive(false);
        for (int i = 0; i < diapos.Length; i++)
        {
            diapos[i].SetActive(false);
        }
        diapos[currentPage].SetActive(true);
    }
    private void Update()
    {
        Navigation();
    }
    void Navigation()
    {
        if (diapos.Length > 0 && currentPage < diapos.Length - 1)
        {
            next.SetActive(true);
        }
        else next.SetActive(false);
        if (diapos.Length > 0 && currentPage >= 1)
        {
            back.SetActive(true);
        }
        else back.SetActive(false);
    }
    public void NextButton()
    {
        diapos[currentPage].SetActive(false);

        currentPage = currentPage + 1;
        diapos[currentPage].SetActive(true);
    }
    public void BackButton()
    {
        diapos[currentPage].SetActive(false);

        currentPage = currentPage - 1;
        diapos[currentPage].SetActive(true);
    }
}
