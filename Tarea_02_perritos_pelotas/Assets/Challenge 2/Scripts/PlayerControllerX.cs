using UnityEngine;
 
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float ratio = 1f;
    private float ultimoRatio = 0;
 
    // Update is called once per frame
    void Update()
    {
        ultimoRatio += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && ultimoRatio > ratio)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            ultimoRatio = 0;
        }
    }
}