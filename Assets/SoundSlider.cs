using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundSlider : MonoBehaviour
{
    public Slider soundSlider;
  
    // Start is called before the first frame update
    private void Awake()
    {
        var Value = SettingData.GetSoundValue();
        soundSlider.value = Value;
    }
    // Update is called once per frame
    public void OnChangeValue(float value)
    {
        SettingData.SetSoundValue(value);
    }
}
