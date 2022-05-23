using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangDropdown : MonoBehaviour
{

    public Dropdown dropdown;

    private List<string> graphicOptionList = new List<string> { "English", "Tieng Viet"};
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
        var index = SettingData.GetLanguageIndex();
        dropdown.value = index;
        dropdown.onValueChanged.AddListener(delegate
        {
            DropdownSelect();
        });
        

    }

    private void DropdownSelect()
    {
        SettingData.SetLanguageIndex(dropdown.value);
    }
}
