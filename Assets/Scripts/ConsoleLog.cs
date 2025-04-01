using System.Collections;
using System.Collections.Generic;
using UnityEngine; // és una llibreria del framework

public class ConsoleLog : MonoBehaviour
{

    private void Awake()// es crida en el primer frame 
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start"); // console.writeline
    }

    // Update is called once per frame
    void Update()
    {

        Debug.LogError("Error!");// per posar el iconito del error a la consola del unity
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        
    }
}
