namespace dotnetconfpl
{
    public static class StreamInfo
    {
        public static string GetMeStreamInfo(string selectedStream)
        {
            switch (selectedStream)
            {
                case "maniserowicz" :
                    return "Maciej Aniserowicz <br/> Testy jednostkow, vol 2";
                case "filipwoj":
                    return "Filip Wojcieszyn <br/> Wszystko co chciałbyś wiedzieć o Roslyn";
                case "basiafusinska":
                    return "Barbara Fusińska <br/> Programowanie zorientowane aspektowo (AOP)";
                case "gutek":
                    return "Jakub Gutkowski <br/> Server Side czy/i Client Side MVC?";
                case "patrykgoralowski":
                    return "Patryk Góralowski <br/> Talent za 2 dolary. Skusisz się!";
                case "maciejgrabek":
                    return "Maciej Grabek <br/> Wymagania biznesowe w formie kodu, czyli kilka słów na temat BDD z użyciem SpecFlow";
                case "michallusiak":
                    return "Michał Łusiak <br/> WTF# - czym jest F# i dlaczego powinno Cię to obchodzić";
                default:
                    return string.Empty;
            }
        }
    }
}