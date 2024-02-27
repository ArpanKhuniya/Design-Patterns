using Adapter;
using System;

public class EnglishSpeaker
{
    public string Name;
    public string messageInEnglish;
}

public class FrenchSpeaker
{
    public string Name;
    public string messageInFrench;
}

public class Program
{
    public static void Main(string[] args)
    {
        EnglishSpeaker englishSpeaker = new EnglishSpeaker();
        englishSpeaker.messageInEnglish = "en";
        Translator translator = new Translator();
        translator.translateEnglishToFrench(englishSpeaker.messageInEnglish);
    }
}