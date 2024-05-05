using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class RoomSpawner : MonoBehaviour
{
    private GameObject LengthSlider;
    private GameObject WidthSlider;
    private GameObject HeightSlider;
    private GameObject SpawnLocation;

    public GameObject SpawnroomPrefab;

    private TextMeshProUGUI LengthValue;
    private TextMeshProUGUI WidthValue;
    private TextMeshProUGUI HeightValue;

    

    private void Start() 
    {
        LengthSlider = GameObject.Find("LengthSlider").gameObject;
        WidthSlider = GameObject.Find("WidthSlider").gameObject;
        HeightSlider = GameObject.Find("HeightSlider").gameObject;
        SpawnLocation = GameObject.Find("Spawn Location").gameObject;

        LengthValue = LengthSlider.transform.GetChild(1).transform.GetChild(2).transform.GetComponent<TextMeshProUGUI>();
        WidthValue = WidthSlider.transform.GetChild(1).transform.GetChild(2).transform.GetComponent<TextMeshProUGUI>();
        HeightValue = HeightSlider.transform.GetChild(1).transform.GetChild(2).transform.GetComponent<TextMeshProUGUI>();
    }
    
    private void FixedUpdate() 
    {
        LengthValue.text = LengthSlider.transform.GetChild(1).GetComponent<UnityEngine.UI.Slider>().value.ToString();
        WidthValue.text = WidthSlider.transform.GetChild(1).GetComponent<UnityEngine.UI.Slider>().value.ToString();
        HeightValue.text = HeightSlider.transform.GetChild(1).GetComponent<UnityEngine.UI.Slider>().value.ToString();
    }

    public void SpawnRoom()
    {
        if (GameObject.FindWithTag("Room") != null)
        {
            Destroy(GameObject.FindWithTag("Room").gameObject);
            GameObject SpawnedRoom = Instantiate(SpawnroomPrefab,SpawnLocation.transform,false);
            SpawnedRoom.transform.localScale = new Vector3(int.Parse(LengthValue.text),int.Parse(WidthValue.text),int.Parse(HeightValue.text));
        }
        else
        {
            GameObject SpawnedRoom = Instantiate(SpawnroomPrefab,SpawnLocation.transform,false);
            SpawnedRoom.transform.localScale = new Vector3(int.Parse(LengthValue.text),int.Parse(WidthValue.text),int.Parse(HeightValue.text));
        }
        
    }
}
