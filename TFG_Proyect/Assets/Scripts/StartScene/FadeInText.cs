using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInText : MonoBehaviour
{
    public float fadeDuration = 2f; //Duración del fade.
    public float blinkSpeed = 0.1f; //Velocidad de parpadeo.
    public float minAlpha = 0.7f; // Mínima opacidad de parpadeo.
    public float maxAlpha = 1.0f; // Máxima opcacidad de parpadeo.

    private CanvasGroup canvasGroup;
    private bool isBlinking = false;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null )
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
        canvasGroup.alpha = 0; //Inicia en opacidad 0.
        StartCoroutine(FadeIn());
    }

    void Update()
    {
        
    }

    private IEnumerator FadeIn()
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(elapsedTime / fadeDuration);
            yield return null;
        }
        canvasGroup.alpha = 1; //Asegura que al final sea 1.
        isBlinking = true;
        StartCoroutine(BlinkEffect()); //Inicia el efecto de parpadeo.
    }

    private IEnumerator BlinkEffect()
    {
        while (isBlinking)
        {
            float randomAlpha = Random.Range(minAlpha, maxAlpha); //Genera una opacidad aleatoria.
            canvasGroup.alpha = randomAlpha;
            yield return new WaitForSeconds(blinkSpeed); //Espera un breve momento antes de cambiar la opcacidad de nuevo.
        }
    }
}
