using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightColor : MonoBehaviour
{
    private Color sColor;
    Renderer render;



    // Start is called before the first frame update
    void Start()
    {

        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        onMouseSelection();
    }

    void onMouseSelection()
    {
        sColor = render.material.color;
        render.material.color = Color.yellow;
    }
}
