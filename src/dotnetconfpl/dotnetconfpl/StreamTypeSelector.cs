namespace dotnetconfpl
{
    public static class StreamInfo
    {
        public static string GetMeStreamInfo(string selectedStream)
        {
            switch (selectedStream)
            {
                case "gutek":
                    return "Jakub Gutkowski <br/> ASP.NET vNext - Na co zwrócić uwagę";
                case "maniserowicz":
                    return "Maciej Aniserowicz <br/> Testy jednostkowe w praktyce, vol 3: testy konwencji";
                case "stappmaniszewski":
                    return "Piotr Stapp i Mateusz Janiszewski <br/> Vagrant with Windows czyli włóczęga z oknami";
                case "wmekal":
                    return "Jakub Gutkowski <br/> Double Loop TDD z MVC 6 w praktyce";
                case "mmalinowski":
                    return "Marcin Malinowski <br/> Funkcyjne zabawki w obiektowej piaskownicy";
                case "ssobotka":
                    return "Sławomir Sobótka <br/> Co było pierwsze: kod czy architektura?";
                case "abenedykt":
                    return "Arkadiusz Benedykt <br/> Internet of Things gdzie zacząć";
                default:
                    return string.Empty;
            }
        }
    }
}