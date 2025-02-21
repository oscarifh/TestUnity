using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Aqui esta Start");
    }
    //int numero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo");
        Debug.LogWarning("Ejemplo de Warning");
        Debug.LogError("Ejemplo de error");
        //numero = 10;

    }


    // Update is called once per frame
    void Update()
    {
        //numero += 1;   
        Debug.Log("Aqui es Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Fixed uptade cada 50 frames");

    }

    private void LateUpdate()
    {
        Debug.Log("Aqui Late Update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("Objeto Habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha sido desabilitado");
    }
}
