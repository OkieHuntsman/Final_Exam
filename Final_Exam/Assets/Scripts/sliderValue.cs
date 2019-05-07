using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class sliderValue : MonoBehaviour
{
    public Slider mainSlider;

    public float sValue = 0;

    public Text slideText;

   public Text valueText;

    void Start()
    {
        slideText.text = "";
        
    }

    //Invoked when a submit button is clicked.
    public void SubmitSliderSetting()
    {
        //Displays the value of the slider in the console.
        sValue = mainSlider.value;
    }

    void Update()
    {
        slideText.text = sValue.ToString("F2");
    }

    void valueEquals()
    {
         
         valueText.text = "";
        valueText.text = sValue.ToString("F2");
    }
}