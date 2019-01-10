using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StarDisplay : MonoBehaviour
{
    private Text displayOfStars;
    public int totalStarsCount = 100;
    public enum Status {SUCCESS, FAILURE};
    

    // Start is called before the first frame update
    void Start()
    {
        displayOfStars = GetComponent<Text>();
        UpdateStarDisplay();
        Debug.Log("totalStarsCount =  " + totalStarsCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddStars(int count)
    {
        totalStarsCount += count;
        UpdateStarDisplay();
    }
        
    public Status UseStars(int count)
    {
        if (totalStarsCount >= count)
        {
            totalStarsCount -= count;
            UpdateStarDisplay();
            return Status.SUCCESS;
        }
        else
        {
            return Status.FAILURE;
        }
    }

    private void UpdateStarDisplay()
    {
        displayOfStars.text = totalStarsCount.ToString();
    }

}
