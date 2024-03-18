using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RoomSpawner : MonoBehaviour
{
    
    [SerializeField]
    private TextMeshProUGUI XNum;

    [SerializeField]
    private TextMeshProUGUI YNum;

    [SerializeField]
    private TextMeshProUGUI ZNum;

    [SerializeField]
    private GameObject RoomPrefab;

    private GameObject SpawnedRoom;

    private GameObject Player;

    private void Start() 
    {
        GameObject.Find("DownX").GetComponent<Button>().onClick.AddListener(delegate{SubNumber("X");});
        GameObject.Find("UpX").GetComponent<Button>().onClick.AddListener(delegate{AddNumber("X");});
        GameObject.Find("DownY").GetComponent<Button>().onClick.AddListener(delegate{SubNumber("Y");});
        GameObject.Find("UpY").GetComponent<Button>().onClick.AddListener(delegate{AddNumber("Y");});
        GameObject.Find("DownZ").GetComponent<Button>().onClick.AddListener(delegate{SubNumber("Z");});
        GameObject.Find("UpZ").GetComponent<Button>().onClick.AddListener(delegate{AddNumber("Z");});
        GameObject.Find("SpawnButton").GetComponent<Button>().onClick.AddListener(SpawnRoom);
        GameObject.Find("ResetButton").GetComponent<Button>().onClick.AddListener(Reset);
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void AddNumber(string NumName)
    {
        switch (NumName)
        {
            case "X":
                    int countX = int.Parse(XNum.text);
                    countX++;
                    XNum.text = countX.ToString();
                    break;

            case "Y" :
                    int countY = int.Parse(YNum.text);
                    countY++;
                    YNum.text = countY.ToString();
                    break;

            case "Z" :
                    int countZ = int.Parse(ZNum.text);
                    countZ++;
                    ZNum.text = countZ.ToString();
                    break;
        }
    }

    private void SubNumber(string NumName)
    {
        switch (NumName)
        {
            case "X":
                    int countX = int.Parse(XNum.text);
                    if (countX > 0)
                    {   
                        countX--;
                        XNum.text = countX.ToString();
                    }
                    break;
                    

            case "Y":
                    int countY = int.Parse(YNum.text);
                    if (countY > 0)
                    {   
                        countY--;
                        YNum.text = countY.ToString();
                    }
                    break;

            case "Z":
                    int countZ = int.Parse(ZNum.text);
                    if (countZ > 0)
                    {   
                        countZ--;
                        ZNum.text = countZ.ToString();
                    }
                    break;
        }
    }
    
    private void SpawnRoom()
    {
        int DimX = int.Parse(XNum.text);
        int DimY = int.Parse(YNum.text);
        int DimZ = int.Parse(ZNum.text);

        SpawnedRoom = Instantiate(RoomPrefab, new Vector3(5,5,-400), Quaternion.identity);
        SpawnedRoom.transform.localScale = new Vector3(DimX, DimY, DimZ);

        Player.transform.position = new Vector3(SpawnedRoom.transform.position.x, SpawnedRoom.transform.position.y - 5, SpawnedRoom.transform.position.z);
    }

    private void Reset()
    {
        XNum.text = "0";
        YNum.text = "0";
        ZNum.text = "0";
        Destroy(SpawnedRoom);
    }
}
