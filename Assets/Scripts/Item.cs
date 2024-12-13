using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour
{
    private Camera mainCamera;
    private Vector2 startPosition;

    void Start()
    {
        mainCamera = Camera.main;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        startPosition = transform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Ustawienie pozycji sprite'a na wierzch
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Obliczenie pozycji myszy w przestrzeni œwiata
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z; // Utrzymanie g³êbi

        // Ustawienie pozycji sprite'a na podstawie pozycji myszy
        transform.position = mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Przywrócenie pozycji sprite'a
        transform.position = startPosition;
    }
}
