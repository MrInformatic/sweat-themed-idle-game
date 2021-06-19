using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.

public class GenericButton : MonoBehaviour, IPointerDownHandler
{
    public float clickScale = 0.75f;

    public float timeToLerp = 0.2f;
    float targetScale = 1f;
    float scaleModifier;

    IEnumerator LerpFunction(float endValue, float duration)
    {
        float time = 0;
        float startValue = scaleModifier;
        Vector3 startScale = new Vector3(1.0f, 1.0f, 1.0f);

        while (time < duration)
        {
            scaleModifier = Mathf.Lerp(startValue, endValue, time / duration);
            transform.localScale = startScale * scaleModifier;
            time += Time.deltaTime;
            yield return null;
        }
        transform.localScale = startScale * targetScale;
        scaleModifier = targetScale;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.localScale = new Vector3(clickScale, clickScale, clickScale);
        scaleModifier = clickScale;
        StartCoroutine(LerpFunction(targetScale, timeToLerp));
    }
}
