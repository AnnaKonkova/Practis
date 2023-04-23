using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySlot 
{
    [SerializeField] private InventoryItemData itemData;
    [SerializeField] private int stackSize;

    public InventoryItemData ItemData => itemData;
    public int StackSize => stackSize;
    public InventorySlot(InventoryItemData source, int amout)
    {
        itemData= source;   
        stackSize=amout;
    }
    public InventorySlot()
    {
        ClearSlot();
    }
    public void ClearSlot()
    {
        itemData=null;
        stackSize=-1;
    }
    public void UpateInventorySlot(InventoryItemData data, int amout)
    {
        itemData= data;
        stackSize=amout;
    }
    public bool RoomLeftInStack(int amoutTOAdd,out int amuntRemaining)
    {
        amuntRemaining = ItemData.MaxStackSize - stackSize;

        return RoomLeftInStack(amoutTOAdd);
    }
    public bool RoomLeftInStack( int amountToAdd)
    {
        return (stackSize + amountToAdd <= itemData.MaxStackSize);
    }
    public void AddToStack(int amout)
    {
        stackSize += amout;
    }
    public void RemoveFromStack(int amout)
    {
        stackSize -= amout;
    }
}
