using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoAboutPlanet : MonoBehaviour {

    [SerializeField] private Text textArea;
    [SerializeField] private string[] strings;
    [SerializeField] private float speed;


    int stringIndex;
    int charIndex;
    void Start()
    {
        charIndex = 0;

        textArea.enabled = false;
    }

    public void StartShowingText(int planetNumber)
    {
        textArea.enabled = true;
        StartCoroutine(DisplayTimer(planetNumber));
    }

    public void StopShowingText(int planetNumber)
    {
        StopAllCoroutines();
        textArea.text = "";
        textArea.enabled = false;
        charIndex = 0;  
    }

    IEnumerator DisplayTimer(int strIndx)
    {
        while (true)
        {
            yield return new WaitForSeconds(speed);
            if (charIndex > strings[strIndx].Length)
            {
                continue;
            }

            textArea.text = strings[strIndx].Substring(0, charIndex);
            charIndex++;
        }
    }

}
