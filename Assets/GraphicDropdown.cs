using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicDropdown : MonoBehaviour
{
    
    public Dropdown dropdown;

    private List<string> graphicOptionList = new List<string> { "Low","Medium","High"};
    private void Awake()
    {
        
        InitDrowdown();
    }

    private void InitDrowdown()
    {
        foreach (var data in graphicOptionList)
        {
            var option = new Dropdown.OptionData()
            {
                text = data,
            };
            dropdown.options.Add(option);
        }
        var index = SettingData.GetGraphicIndex();
        dropdown.value = index;
        dropdown.onValueChanged.AddListener(delegate
        {
            DropdownSelect();
        });

    }

    private void DropdownSelect()
    {
        Debug.Log("graphic dropdown value"+ dropdown.value);
        SettingData.SetGraphicIndex(dropdown.value);
    }
}
