namespace dotnetconfpl
{
    public static class StreamInfo
    {
        public static string GetMeStreamInfo(string selectedStream)
        {
            switch (selectedStream)
            {
                case "intro":
                    return "dotNetConfPL - Intro";
                case "outro":
                    return "dotNetConfPL - Outro";
                case "jankowski":
                    return "Michał Jankowski <br/> 3… 2… 1… LIFT OFF… COSMOSDB";
                case "jedrzejewski-1":
                    return "Maciej Jędrzejewski <br/> .NET CORE, DOCKER I HEROKU - TOGETHER FOREVER";
                case "mrzyglod":
                    return "Kamil Mrzygłód <br/> AZURE FUNCTIONS - PISANIE WŁASNYCH ROZSZERZEŃ";
                case "owsiany":
                    return "Krzysztof Owsiany <br/> IL — MIĘDZY PIEKŁEM A NIEBEM";
                case "lamch":
                    return "Joanna Lamch <br/> WEBASSEMBLY AND .NET";
                case "furmanek":
                    return "Adam Furmanek <br/> BEBECHY WYJĄTKÓW";
                case "jedrzejewski-2":
                    return "Maciej Jędrzejewski <br/> MACHINE LEARNING W .NET - CZYLI PODRÓŻ TAM I Z POWROTEM";
                default:
                    return "dotnetconf.pl - start o 14:00";
            }
        }
    }
}