using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Clase responsable de generar cubos en la escena.
/// </summary>
public class Spawner : MonoBehaviour
{
    /// <summary>
    /// Prefab del cubo que se va a instanciar.
    /// </summary>
    public GameObject cubePrefab;

    /// <summary>
    /// Lista que contiene los cubos generados.
    /// </summary>
    public List<GameObject> listadecubos;

    /// <summary>
    /// Factor de escalamiento para los cubos.
    /// </summary>
    public float factorDeEscalamiento;

    /// <summary>
    /// Contador del número de cubos generados.
    /// </summary>
    public int numCubos = 0;

    /// <summary>
    /// Método llamado antes de la primera actualización del frame.
    /// Inicializa la lista de cubos.
    /// </summary>
    void Start()
    {
        listadecubos = new List<GameObject>();
    }

    /// <summary>
    /// Método llamado una vez por frame.
    /// Genera un nuevo cubo, le asigna un color aleatorio y lo posiciona en una ubicación aleatoria dentro de una esfera unitaria.
    /// </summary>
    void Update()
    {
        /// <summary>
        /// Incrementa el contador de cubos, instancia un nuevo cubo, le asigna un color aleatorio y lo posiciona en una ubicación aleatoria dentro de una esfera unitaria.
        /// </summary>
        {
            numCubos++; //Se aumenta el nummero de cubos
            GameObject tempGameObject = Instantiate<GameObject>(cubePrefab); //Se instancia el cubo
            tempGameObject.name = "Cube" + numCubos.ToString();//Se le asigna un nombre al cubo
            Color r = new Color(Random.value, Random.value, Random.value); //Crear un color aleatorio 

            tempGameObject.GetComponent<MeshRenderer>().material.color = r; //Se le asigna el color r(Aleatorio) al cubo

            tempGameObject.transform.position = Random.insideUnitSphere; //Se le asigna una posicion aleatoria dentro de una esfera unitaria

            listadecubos.Add(tempGameObject); //Se añade el cubo a la lista de cubos

            List<GameObject> cubosParaDestruir = new List<GameObject>(); //Lista de cubos para destruir

            // Recorre la lista de cubos y escala cada uno de ellos
            foreach (GameObject cubo in listadecubos)//Recorre la lista de cubos
            {
                float scale = cubo.transform.localScale.x; //Se obtiene la escala del cubo
                scale *= factorDeEscalamiento; //Se multiplica la escala por el factor de escalamiento

                cubo.transform.localScale = Vector3.one * scale; //Se le asigna la nueva escala al cubo

                // Si la escala del cubo es menor o igual a 0.1, se añade a la lista de cubos para destruir
                if (scale <= 0.1)
                {
                    cubosParaDestruir.Add(cubo); //Se añade el cubo a la lista de cubos para destruir
                }
            }

            // Destruye los cubos cuya escala es menor o igual a 0.1
            foreach (GameObject cubo in cubosParaDestruir)
            {
                listadecubos.Remove(cubo); //Se remueve el cubo de la lista de cubos
                Destroy(cubo); //Se destruye el cubo    
            }
        }
    }
}