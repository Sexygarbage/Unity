using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTest : MonoBehaviour, IPointerClickHandler {

    public Light light;

    public void OnPointerClick(PointerEventData eventData) {
        float r = UnityEngine.Random.Range(0f, 1f);
        float g = UnityEngine.Random.Range(0f, 1f);
        float b = UnityEngine.Random.Range(0f, 1f);

        light.color = new Color(r, g, b);
    }
}
