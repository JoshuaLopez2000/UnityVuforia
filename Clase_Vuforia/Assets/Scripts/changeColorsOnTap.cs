using UnityEngine;

public class ChangeColorOnTouch : MonoBehaviour
{
    private Renderer objectRenderer;

    void Start()
    {
        // Obtén el Renderer del objeto para poder cambiar el color
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Detectar si hay un toque en la pantalla
        if (Input.GetMouseButtonDown(0))
        {
            // Cambiar el color del material del objeto
            objectRenderer.material.color = GetRandomColor();
        }
    }

    // Método para generar un color aleatorio
    Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
