using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject plane; // aqui pongo el modelo que esta dentro del objeto vacio
    private float verticalInput, horizontalInput;
    
    [Range(0,20)]
    public float speed = 5f;
    
    [Range(0,90)]
    public float rotationVertical = 45f;
    
    [Range(0,45)]
    public float rotationHorizontal = 22f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Guardamos en input vertical y horizontal
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // movemos el avion hacia adelante
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
 
        // Giramos el avion arriba y abajo usando el input vertical
        this.transform.Rotate(Vector3.right * rotationVertical * Time.deltaTime * verticalInput);
        
        // Giramos el avion derecha e izquierda usando el input horizontal
        this.transform.Rotate(Vector3.up * rotationHorizontal * Time.deltaTime * horizontalInput);
        plane.transform.Rotate(Vector3.back * rotationHorizontal * Time.deltaTime * horizontalInput / 2f);
    }
}