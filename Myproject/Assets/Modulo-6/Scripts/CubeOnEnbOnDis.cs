using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeOnEnbOnDis : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cubePrefab;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        GameObject tempGameObjet = Instantiate(cubePrefab);
        Debug.Log("Cubo en la funcion 'OnEnable'");
    }

    private void OnDisable()
    {
        GameObject tempGameObjet = Instantiate(cubePrefab);
        Debug.Log("Cubo en la funcion 'OnDisable'");
    }
}
