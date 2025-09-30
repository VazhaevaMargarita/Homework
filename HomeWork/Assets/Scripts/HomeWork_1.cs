using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork_1 : MonoBehaviour
{
    private int[] _numbers = { 2, 13, -7, 3, -57, -42 }; 
    private int _negative = 0;
    void Start()
    {
        for(int i = 0; i < _numbers.Length; i++)
        {
            if (_numbers[i] < 0)
            {
                _negative++;
            }
        }
        Debug.Log($"Отрицательных чисел: {_negative}");
    }
}
