using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create Item")]
public class Item : ScriptableObject

//Clase pa almacenar datos 
{
    public int id;
    public string ItemName;
    public int value;
    public Sprite icon;
}