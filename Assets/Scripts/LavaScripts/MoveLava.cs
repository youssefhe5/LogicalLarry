using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLava : MonoBehaviour
{

    public float scrollSpeed = 0.05f;
    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Time.time * scrollSpeed;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(0, move));

    }
}
