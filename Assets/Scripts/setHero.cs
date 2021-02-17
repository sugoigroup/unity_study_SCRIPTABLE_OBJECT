using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class setHero : MonoBehaviour
{
    [SerializeField]
    test data;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(data.sName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
