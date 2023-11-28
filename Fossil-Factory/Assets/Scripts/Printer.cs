using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Printer", menuName = "Printer")]
public class Printer : ScriptableObject
{
    public float _productionRate;
    public float _cost;
    public float _price;
    public Sprite sprite;
}
