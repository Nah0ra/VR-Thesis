using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class RoomSpawner : MonoBehaviour
{
    private GameObject LengthSlider;
    private GameObject WidthSlider;
    private GameObject HeightSlider;

    private TextMeshProUGUI LengthValue;
    private TextMeshProUGUI WidthValue;
    private TextMeshProUGUI HeightValue;

    

    private void Start() 
    {
        LengthSlider = GameObject.Find("LengthSlider").gameObject;
        WidthSlider = GameObject.Find("WidthSlider").gameObject;
        HeightSlider = GameObject.Find("HeightSlider").gameObject;

        LengthValue = LengthSlider.transform.GetChild(1).transform.GetChild(3).transform.GetComponent<TextMeshProUGUI>();
        WidthValue = WidthSlider.transform.GetChild(1).transform.GetChild(3).transform.GetComponent<TextMeshProUGUI>();
        HeightValue = HeightSlider.transform.GetChild(1).transform.GetChild(3).transform.GetComponent<TextMeshProUGUI>();
    }
    
    private void FixedUpdate() 
    {
        LengthValue.text = LengthSlider.transform.GetChild(1).GetComponent<Slider>().value.ToString();
        WidthValue.text = WidthSlider.transform.GetChild(1).GetComponent<Slider>().value.ToString();
        HeightValue.text = HeightSlider.transform.GetChild(1).GetComponent<Slider>().value.ToString();
    }
}
