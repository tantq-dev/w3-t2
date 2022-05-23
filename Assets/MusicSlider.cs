using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider musicSlider;

    // Start is called before the first frame update
    private void Awake()
    {
        var Value = SettingData.GetMusicValue();
        musicSlider.value = Value;
    }
    // Update is called once per frame
    public void OnChangeValue(float value)
    {
        SettingData.SetMusicValue(value);
    }
}
