using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public Transform SpawnArea;
    public List<GameObject> SpawnAbles;

    [SerializeField]
    private List<GameObject> SpawnedItems;

    public void SpawnItem(string ItemName)
    {
        switch (ItemName)
        {
            case "Table":
                GameObject Table = Instantiate(SpawnAbles[0], SpawnArea.transform.position,Quaternion.Euler(-90,0,0));
                SpawnedItems.Add(Table);
                break;

            case "Chair":
                GameObject Chair = Instantiate(SpawnAbles[1], SpawnArea.transform.position, Quaternion.Euler(-90, 0, 0));
                SpawnedItems.Add(Chair);
                break;

            case "Chair2":
                GameObject Chair2 = Instantiate(SpawnAbles[2], SpawnArea.transform.position, Quaternion.Euler(-90,0,0));
                SpawnedItems.Add(Chair2);
                break;
        }
    }

    public void ResetItems()
    {
        foreach (GameObject item in SpawnedItems)
        {
            Destroy(item);
        }
    }
}
