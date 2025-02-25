using System.Globalization;
using System.Resources;
using Trener.Resources.Languages; // Namespace pro RESX soubory

public static class ResourceHelper
{
    private static readonly ResourceManager resourceManager =
        new ResourceManager("Trener.Resources.Languages.Resources", typeof(Resources).Assembly);

    public static string GetResourceValue(string key)
    {
        return resourceManager.GetString(key, CultureInfo.CurrentUICulture) ?? $"[Key '{key}' not found]";
    }

    public static void ChangeLanguage(string culture)
    {
        CultureInfo.CurrentCulture = new CultureInfo(culture);
        CultureInfo.CurrentUICulture = new CultureInfo(culture);
    }

    public static void ChangeText(Button button, string resourceKey)
    {
        button.Text = GetResourceValue(resourceKey);
    }
}
