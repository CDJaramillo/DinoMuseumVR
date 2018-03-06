using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlImagenes : MonoBehaviour
{
    private Vector3 originalScale;
    private Vector3 destinationScale;

    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }

    public void MostrarInformacion()
    {
        StartCoroutine(ScaleOverTime(1));
    }

    IEnumerator ScaleOverTime(float time)
    {
        originalScale = this.transform.localScale;
        destinationScale = new Vector3(0.264843f, 0.8348757f, 2.825668f);

        float currentTime = 0.0f;

        do
        {
            this.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;
        }
        while (currentTime <= time);

        this.transform.localScale = destinationScale;
    }

    public void OcultarInformacion()
    {
        this.transform.localScale = originalScale;
    }
}