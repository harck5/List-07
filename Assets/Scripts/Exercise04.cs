using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    public int num = 0;
    public GameObject Cubo;

    void Start()
    {
        Instantiate(Cubo, Vector3.zero, Quaternion.identity);
        StartCoroutine(Counter());
    }
    private IEnumerator Counter()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(2);
            Debug.Log(message: "hola");
        }
    }
}
