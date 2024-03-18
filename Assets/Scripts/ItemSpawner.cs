using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemSpawner : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> SpawnedObjects;

    [SerializeField]
    private List<GameObject> SpawnAbles;

    [SerializeField]
    private GameObject ResetItems;

    private GameObject Player;

    private void Awake() 
    {
        ResetItems.GetComponent<Button>().onClick.AddListener(DeleteItems);
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Reveal()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void SpawnItem(string Item)
    {
        switch (Item)
        {
            case "Sofa":
                GameObject Spawned = Instantiate(SpawnAbles[0], gameObject.transform.position, Quaternion.identity);
                SpawnedObjects.Add(Spawned);
                break;
        }
    }

    public void DeleteItems()
    {
        foreach (GameObject item in SpawnedObjects)
        {
            Destroy(item);
        }
        SpawnedObjects.Clear();
    }
}
