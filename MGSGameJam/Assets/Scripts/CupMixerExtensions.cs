using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CupMixerExtensions
{
    public static T[] ShuffleArray<T>(T[] array)
    {
        T[] newArray = (T[])array.Clone();
        int n = newArray.Length;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = newArray[k];
            newArray[k] = newArray[n];
            newArray[n] = value;
        }
        return newArray;
    }

    // Smoothly moves an object over time using Lerp
    public static IEnumerator SmoothMove(this GameObject g, Vector3 targetPosition, float duration)
    {
        Vector3 startPosition = g.transform.position;
        float timeElapsed = 0;

        while (timeElapsed < duration)
        {
            g.transform.position = Vector3.Lerp(startPosition, targetPosition, timeElapsed / duration);
            timeElapsed += Time.deltaTime; 
            yield return null;
        }

        // Ensure it lands exactly on the target at the end
        g.transform.position = targetPosition;
    }
}
