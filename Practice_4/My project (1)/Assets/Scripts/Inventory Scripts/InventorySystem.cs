using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class InventorySystem
{
    [SerializeField] private List<InventorySlot> inventorySlots;

    public List<InventorySlot> InventorySlots => inventorySlots;
    public int InventorySize => InventorySlots.Count;

    public UnityAction<InventorySlot> OnInventorySlotChanged;
    public InventorySystem(int size)
    {
        inventorySlots = new List<InventorySlot>(size);

        for (int i = 0; i < size; i++)
        {
            inventorySlots.Add(new InventorySlot());

        }
    }
    public bool AddToInventory(InventoryItemData itemToAdd, int amountToAdd)
    {
        if(ContainsItem(itemToAdd,out List<InventorySlot> invSlot))
        {
            foreach(var slot in invSlot){
                if (slot.RoomLeftInStack(amountToAdd))
                {
                    slot.AddToStack(amountToAdd);
                    OnInventorySlotChanged?.Invoke(slot);
                    return true;
                }
            }
            
        }

        if (HasFreeSlot(out InventorySlot freeSlot))
        {
            freeSlot.UpateInventorySlot (itemToAdd,amountToAdd);
            OnInventorySlotChanged?.Invoke(freeSlot);
            return true;
        }
        return false;
    }
   
     public bool ContainsItem(InventoryItemData itemToAdd,out List<InventorySlot> invSlot) {
        invSlot=InventorySlots.Where(i=> i.ItemData== itemToAdd).ToList();
        Debug.Log(invSlot.Count);
        return invSlot.Count>1;
    }
    public bool HasFreeSlot(out InventorySlot freeSlot)
    {
        freeSlot= InventorySlots.FirstOrDefault(i=> i.ItemData== null);
        return freeSlot != null;
    }

}