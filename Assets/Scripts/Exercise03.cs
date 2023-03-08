using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise03 : MonoBehaviour
{
    public int num = 0;
    public TextMeshProUGUI texto;
    void Update()
    {
            Counter();
    }
    private void Counter()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ++num;
            texto.text = $"{num}";
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            --num;
            texto.text = $"{num}";
        }
    }
}
