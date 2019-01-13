using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinGrattersText : MonoBehaviour
{
    [SerializeField] private float fontAppearingDelay;
    [SerializeField] private float minFontSize;
    [SerializeField] private float maxFontSize;
    private float currentFontSize;
    private float timeSinceGameObjectActive;
    private bool fontScaleTrigger;
    private TextMeshProUGUI winText;

    // Start is called before the first frame update
    void Start()
    {
        currentFontSize = minFontSize;
        winText = GetComponent<TextMeshProUGUI>();
        winText.fontSize = Mathf.RoundToInt(currentFontSize);
        timeSinceGameObjectActive = 0;
        fontScaleTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (fontScaleTrigger)
        {
            currentFontSize += (maxFontSize - minFontSize) * Time.deltaTime / fontAppearingDelay;
            winText.fontSize = Mathf.RoundToInt(currentFontSize);
            timeSinceGameObjectActive += Time.deltaTime;
            
            if (timeSinceGameObjectActive >= fontAppearingDelay)
            {
                fontScaleTrigger = false;
            }
        }
    }

    public void ShowWinText()
    {
        gameObject.SetActive(true);

    }
}
