namespace HelloWorldLibrary.Models;
    public class CustomText
    {
    public CustomText(Dictionary<string, string> translations)
    {
        Translations = translations;
    }

    public string Language { get; set; }
    public Dictionary<string, string> Translations { get; set; }
    }

