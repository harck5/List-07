using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    public GameObject Cubo;
    public float x;
    public float y;
    public float z;

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            x = Random.Range(5, -5);
            y = Random.Range(5, -5);
            z = Random.Range(5, -5);

            Vector3 pos = new Vector3(x, y, z);
            GameObject inst = Instantiate(Cubo, pos, Quaternion.identity);
            inst.transform.localScale = Vector3.one * Random.Range(0, 4);
        }
    }
}
