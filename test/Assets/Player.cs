using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
     public event Action OnDeathEvent;
         public event Action<int, GameObject> OnTakeDamageEvent;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
[NaughtyAttributes.Button()]
    public void test()
    {
        OnDeathEvent?.Invoke();

    }
}
