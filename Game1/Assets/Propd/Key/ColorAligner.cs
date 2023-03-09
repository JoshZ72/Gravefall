using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAligner : MonoBehaviour
{
    [SerializeField]
    private Color color;

    [SerializeField]
    private List<SpriteRenderer> renderersToAlign;

    private void OnValidate()
    {
        renderersToAlign.ForEach(sp => sp.color = color);
    }

}
