using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory
{
    [Test]
    public void only_allows_one_chest_to_be_equipped_at_a_time()
    {
        // Arrange
        Inventory inventory = new Inventory();
        Item chestOne = new Item() { EquipSlot = EquipSlots.Chest };
        Item chestTwo = new Item() { EquipSlot = EquipSlots.Chest };

        // Act
        inventory.EquipItem(chestOne);
        inventory.EquipItem(chestTwo);

        // Assert
        Item equippedItem = inventory.GetItem(equipSlot: EquipSlots.Chest);
        Assert.AreEqual(expected: chestTwo, actual: equippedItem);
    }
}
