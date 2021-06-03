using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // Comentario de una sola linea
    
    /*
     * Comentario de varias lineas
     */
    //  [HideInInspector] // Oculta la variable en el inspector
    
    [Range(0,20)] // Limita los valores que puede tener la variable en el inspector
    [SerializeField] // permite modificar el valor de una variable privada en el inspector
    [Tooltip("Velocidad maxima a la que puede moverse el vehiculo")] // permite comentar
    private float speed = 10f;
    
    [Range(0,90)]
    [SerializeField]  
    [Tooltip("Velocidad maxima a la que puede girar el vehiculo")] 
    private float turnSpeed = 45f;

    [Tooltip("Para controlar por teclaro el movimiento de derecha e izquierda")]
    private float horizontalInput;
    
    [Tooltip("Para controlar por teclaro la acereracion y el frenado")]
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Tenemos que mover el vehiculo hacia adelante
        //  this.transform.Translate(0,0,1);
        //  this.transform.Translate(Vector3.forward);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        // S = V * T (espacio = espacioAnterior + (velocidad * tiempo * direccion))
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime 
                                 * verticalInput);
        this.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime 
                                 * horizontalInput);
    }
}