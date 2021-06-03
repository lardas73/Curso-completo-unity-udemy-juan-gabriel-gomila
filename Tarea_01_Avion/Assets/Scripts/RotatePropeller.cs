using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    public float velocidad = 2000f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(velocidad * Time.deltaTime * Vector3.forward);
    }
}
