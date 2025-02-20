﻿using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ItemsCount;
    private Inventory inventory;

    [SerializeField] private GameObject GameCompletePanel;

    private void Start()
    {
        GameCompletePanel.SetActive(false);
        inventory = Inventory.Instance;
    }

    private void Update()
    {
        string items = "Items Collected : " + inventory.items.Count + " / 15";
        ItemsCount.text = items;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            GameCompletePanel.SetActive(true);
        }
    }
}
