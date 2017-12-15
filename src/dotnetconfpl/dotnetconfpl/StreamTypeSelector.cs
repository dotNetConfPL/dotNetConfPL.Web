namespace dotnetconfpl
{
    public static class StreamInfo
    {
        public static string GetMeStreamInfo(string selectedStream)
        {
            switch (selectedStream)
            {
                case "zajkowski":
                    return "Marcin Zajkowski <br/> Co nowego w C#7, 7.x i....8!";
                case "stapp":
                    return "Piotr Stapp <br/> CCC - Cloud, Continious, Configuration";
                case "pawlukiewicz":
                    return "Dariusz Pawlukiewicz <br/> It's all about the state, czyli co skrywa async/await w C#?";
                case "owsiany":
                    return "Krzysztof Owsiany <br/> Grywalizacja + projektowanie na wybranym przykładzie";
                case "dziubiak":
                    return "Marian Dziubiak <br/> Porównanie MVC w F# z Suave oraz w C# z ASP.NET Core";
                case "furmanek":
                    return "Adam Furmanek <br/> Ręczne zarządzanie pamięcią w .NET";
                case "antonowicz":
                    return "Damian Antonowicz <br/> Xamarin - jak się do tego zabrać?";
                case "pyrzyk":
                    return "Łukasz Pyrzyk <br/> Ile (nie) wiesz o strukturach w .NET";
                default:
                    return "dotnetconf.pl - start o 14:00";
            }
        }
    }
}