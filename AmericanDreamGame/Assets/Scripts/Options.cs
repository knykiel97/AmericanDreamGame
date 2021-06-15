using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    private Text languageText;
    private int language;

    private Dictionary<int, string> languages = new Dictionary<int, string>()
    {
        { 0, "English" },
        { 1, "Polski" }
    };

    // Start is called before the first frame update
    private void Start()
    {
        languageText = GameObject.Find("LanguageText").GetComponent<Text>();
        LoadPrefs();
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("language", language);

        PlayerPrefs.Save();
    }

    public void LanguageSliderOnChanged(Slider slider)
    {
        Debug.Log("New value" + slider.value);
        language = (int)slider.value;
        ChangeLanguageText();
    }

    private void ChangeLanguageText()
    {
        languageText.text = languages[language];
    }

    private void LoadPrefs()
    {
        language = PlayerPrefs.GetInt("language", 0);

        ChangeLanguageText();
        SetSliderValue();
    }

    private void SetSliderValue()
    {
        GameObject.Find("LanguageSlider").GetComponent<Slider>().value = language;
    }
}
