namespace dotnetconfpl
{
    public static class StreamInfo
    {
        public static string GetMeStreamInfo(string selectedStream)
        {
            switch (selectedStream)
            {
                case "maniserowicz" :
                    return "Maciej Aniserowicz <br/> Testy jednostkowe w .NET";
                case "filipwoj":
                    return "Filip Wojcieszyn <br/> scriptcs - C# na diecie";
                case "lukaszgasior":
                    return "Łukasz Gąsior <br/> ReSharper i inne dopalacze programisty";
                case "gutek":
                    return "Jakub Gutkowski <br/> JavaScript dla C# developera";
                case "mgrabek":
                    return "Maciej Grabek <br/> Windows Phone 8 Tips & Tricks";
                case "tjanczuk":
                    return "Tomasz Janczuk <br/> Node.js, Edge.js i Windows Azure";
                default:
                    return string.Empty;
            }
        }
    }
}