using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Torn.Interact
{
    public class Consumable
    {
        public int maxItemStack = 99;   // Maximum stack of the item

        public int itemCounter;     // Counter of the item

        // Get the current amount of the consumable
        public int GetCurrentCount() { return itemCounter; }

        // Add consumable to the player. Default is 1;
        public void AddConsumable(int n = 1)
        {
            itemCounter += n;   // Add to the counter

            Debug.Log($"Pills Left: {GetCurrentCount()}");  // Display to the player
        }

        // Player uses consumable
        public void UseConsumable()
        {
            // Check if the item counter can be reduced to 0
            if (itemCounter > 0)
            {
                itemCounter--;  // Remove 1 from counter
            }
            else
            {
                itemCounter = 0;    // Set to a minimum of 0
            }

            Debug.Log($"Pills Left: {GetCurrentCount()}");  // Notify to the player
        }
    }
}
