using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class zodiac : MonoBehaviour
{
    public TextAsset file;
    public TextMeshProUGUI uitext;

    private Dictionary<string, string> dataZodiacDictionary;
    // Start is called before the first frame update
    void Start()
    {
        var text=file.text;
        var zodiacs = text.Split("\n");
        dataZodiacDictionary=new Dictionary<string, string>();
        foreach (var item in zodiacs)
        {
            var key_value = item.Split(':');
            dataZodiacDictionary.Add(key_value[0], key_value[1]);
        }
    }


    public void ClickZodiac(string key)
    {
        uitext.text = dataZodiacDictionary[key];
    }
}
