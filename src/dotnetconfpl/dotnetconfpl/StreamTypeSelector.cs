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
                case "quiz":
                    return "Quiz wiedzy!";
                case "convey":
                    return "Convey - prosty przepis na mikroserwisy";
                case "stapp":
                    return "Orkiestracja to zło (koniecznie)";
                case "grzybek":
                    return "From anemic to rich domain model: refactoring live session";
                case "nowak":
                    return "Use Azure DevOps to deploy Azure Function in Docker on Raspberry PI";
                case "iot":
                    return "Internet of Things on Azure";
                case "haracz":
                    return "Jak Event-Driven development pozwolił zbudować skalowalny system";
                default:
                    return "dotnetconf.pl - start o 17:45";
            }
        }
    }
}