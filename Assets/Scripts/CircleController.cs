using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Fade();
        }

        if (Input.GetKeyDown("w"))
        {
            StartCoroutine("FadeCoroutine");
        }

        if (Input.GetKeyDown("e"))
        {
            IEnumerator theCoroutine;
            theCoroutine = FadeCoroutine();
            StartCoroutine(theCoroutine);
        }
        if (Input.GetKeyDown("r"))
        {
            ResetSpriteRenderer();
        }
    }

    void Fade()
    {
        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            Color c = spriteRenderer.material.color;
            c.a = f;
            spriteRenderer.material.color = c;
        }
    }

    IEnumerator FadeCoroutine()
    {
        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            Color c = spriteRenderer.material.color;
            c.a = f;
            spriteRenderer.material.color = c;
            yield return new WaitForSeconds(1.0f);
        }
    }

    void ResetSpriteRenderer()
    {
        Color c = spriteRenderer.material.color;
        c.a = 1f;
        spriteRenderer.material.color = c;
    }
}
