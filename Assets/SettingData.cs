using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SettingData {
    public const string SETTING_DATA = "setting_data";
    private static AllSettingData allSettingData;
    static SettingData() {
        allSettingData = JsonUtility.FromJson<AllSettingData>(PlayerPrefs.GetString(SETTING_DATA));

        if (allSettingData == null)
        {
            allSettingData = new AllSettingData
            {
              musicIndex = 1,
              soundIndex = 1,
              graphicIndex = 0,
              languageIndex = 0,
            };
            SaveData();
        }
        
    }
   public static void SaveData()
    {
        PlayerPrefs.SetString(SETTING_DATA, JsonUtility.ToJson(allSettingData));
    }
    public static float GetSoundValue()
    {
        return allSettingData.soundIndex;
    }
    public static void SetSoundValue(float soundValue)
    {
        allSettingData.SetSoundValue(soundValue);
        SaveData();
    }
    public static float GetMusicValue()
    {
        return allSettingData.musicIndex;
    }
    public static void SetMusicValue(float musicValue)
    {
        allSettingData.SetMusicValue(musicValue);
        SaveData();
    }
    
    public static int GetGraphicIndex()
    {
        return allSettingData.graphicIndex;
    }
    public static void SetGraphicIndex(int graphicIndex)
    {
        allSettingData.SetGraphicIndex(graphicIndex);
        SaveData();
    }
    public static int GetLanguageIndex()
    {
        return allSettingData.languageIndex;
    }
    public static void SetLanguageIndex(int languageIndex)
    {
        allSettingData.SetLanguageIndex(languageIndex);
        SaveData();
    }

}
public class AllSettingData
{
    public float musicIndex;
    public float soundIndex;
    public int graphicIndex;
    public int languageIndex;
    public void SetSoundValue(float soundValue)
    {
        this.soundIndex = soundValue;
    }
    public void SetMusicValue (float musicValue)
    {
        this.musicIndex = musicValue;   
    }
    public void SetGraphicIndex(int graphicIndex)
    {
        this.graphicIndex = graphicIndex;   
    }
    public void SetLanguageIndex(int languegeIndex)
    {
        this.languageIndex = languegeIndex;
    }
}
