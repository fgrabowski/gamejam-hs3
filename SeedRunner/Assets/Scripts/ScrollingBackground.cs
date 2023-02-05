using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{

    public float scrollSpeed = 0.05f;
    private SpriteRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _renderer.material.mainTextureOffset = new Vector2(Time.fixedTime * scrollSpeed, 0);
    }
}
