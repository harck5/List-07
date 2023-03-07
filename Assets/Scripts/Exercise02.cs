using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    public int num = 0;
    public TextMeshProUGUI texto;
    void Start()
    {
        StartCoroutine(Counter());
    }
    private IEnumerator Counter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            ++num;
            texto.text = $"{num}";
        }
    }
}
