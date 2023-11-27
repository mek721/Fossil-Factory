using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Floats

    public float _money;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney(float amount)
    {
        _money += amount;
    }

    public void RemoveMoney(float amount)
    {
        _money -= amount;
    }
}
