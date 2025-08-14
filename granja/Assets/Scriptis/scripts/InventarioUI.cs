using UnityEngine;
using UnityEngine.UIElements;

public class InventarioUI : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosPrevios = -1;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("labelHuevos");
    }

    void Update()
    {
        int huevosActuales = GameManager.instancia.conteoHuevos;

        if (huevosActuales != huevosPrevios)
        {
            huevosPrevios = huevosActuales;
            labelHuevos.text = "Huevos: " + huevosPrevios.ToString();
        }
    }
}
