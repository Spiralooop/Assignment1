using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : MonoBehaviour
{
    public float numb1;
    public float numb2;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sum(numb1, numb2));
        Debug.Log(Sum(4, 7));

        Debug.Log(Prod(numb1, numb2));
        Debug.Log(Prod(4, 7));

        Debug.Log(Div(numb1, numb2));
        Debug.Log(Div(4, 7));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    float Sum(float a, float b)
    {
        float Result = a + b;
        return Result;

    }

    float Prod(float a, float b)
    {
        float Res2 = a * b;
        return Res2;

    }

    float Div(float a, float b)
    {
        if (b == 0)
        {
            Debug.LogError("Impossible");
            return float.NaN;
        }

        else
        {
            float Result = a / b;
            return Result;
        }
        
    }

}
