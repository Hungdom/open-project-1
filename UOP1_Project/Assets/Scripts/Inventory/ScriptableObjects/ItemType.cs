﻿using UnityEngine;
using UnityEngine.Localization;
// Created with collaboration from:
// https://forum.unity.com/threads/inventory-system.980646/

public enum itemInventoryType
{
	recipe,
	utensil,
	ingredient,
	customisation,
	dish,

}
public enum ItemInventoryActionType
{
	cook,
	use,
	equip,
	doNothing

}

[CreateAssetMenu(fileName = "ItemType", menuName = "Inventory/ItemType", order = 51)]
public class ItemType : ScriptableObject
{
	[Tooltip("The action associated with the item type")]
	[SerializeField]
	private LocalizedString _actionName;

	[Tooltip("The action associated with the item type")]
	[SerializeField]
	private LocalizedString _typeName;

	[Tooltip("The Item's background color in the UI")]
	[SerializeField] private Color _typeColor;
	[Tooltip("The Item's type")]
	[SerializeField] private itemInventoryType _type;

	[Tooltip("The Item's action type")]
	[SerializeField] private ItemInventoryActionType _actionType;


	[Tooltip("The tab type under which the item will be added")]
	[SerializeField] private InventoryTabType _tabType;

	public LocalizedString ActionName => _actionName;
	public LocalizedString TypeName => _typeName;
	public Color TypeColor => _typeColor;
	public ItemInventoryActionType ActionType => _actionType;
	public itemInventoryType Type => _type;
	public InventoryTabType TabType => _tabType;
}
