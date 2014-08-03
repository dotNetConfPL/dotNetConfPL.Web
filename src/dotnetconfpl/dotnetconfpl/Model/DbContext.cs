using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotnetconfpl.Model
{
    // images dir: http://dotnetconfpl.apphb.com/Content/images/
    public class DbContext
    {
        List<Session> _sessions = new List<Session>();
        List<Speaker> _speakers = new List<Speaker>();

        public DbContext()
        {
            var speaker1 = new Speaker
            {
                Id = 1,
                Name = "Maciej Aniserowicz",
                About = "MVP i najpopularniejszy <a href=\"http://www.maciejaniserowicz.com/\">blogger</a> w polskim środowisku .NET. Miłośnik testów jednostkowych, Gita i Resharpera, zatwardziały wróg TFSa i Sharepointa. Z zawodu programista/architekt .NET w firmie Ultrico. Wcześniej pracował w firmie Predica. Przez pewien czas był także Freelancerem. Ponadto jest dwukrotnym finalistą ImagineCup i byłym redaktorem <a href=\"http://codeguru.geekclub.pl/\">CodeGuru.pl</a>.",
                Photo = "maciej_aniserowicz.jpg"
            };

            var speaker2 = new Speaker
            {
                Id = 2,
                Name = "Maciej Grabek",
                About = "MVP, <a href=\"http://maciejgrabek.com/\">blogger</a>, głównie zajmuje się platformą Windows Phone. Prelegent na <a href=\"http://www.mtskonferencja.pl/\">Microsoft Technology Summit</a> w 2011 i 2012 roku, redaktor <a href=\"http://codeguru.geekclub.pl/\">CodeGuru.pl</a>, współtwórca serii webcastów poświęconych technologii <a href=\"http://channel9.msdn.com/Series/Kurs-programowania-Windows-Phone-7\">Windows Phone 7</a> oraz <a href=\"http://channel9.msdn.com/Series/Tworzenie-aplikacji-dla-systemu-Windows-Phone-8\">Windows Phone 8</a>. Ponadto współzałożyciel <a href=\"http://wss.pl/group-134/Default.aspx\">Toruńskiej Grupy Developerów .NET</a>. Zajmuje się .NETem od czasów studiów i wersji 1.1.",
                Photo = "maciej_grabek.jpg"
            };

            var speaker3 = new Speaker
            {
                Id = 3,
                Name = "Tomasz Janczuk",
                About = "Do września 2013 pracownik Microsoftu w Redmond (USA). Ostatnio zajmował się Node.js, JavaScript i Windows Azure. Wcześniej pracował przy .NET Framework i Silverlight, a dokładniej przy technologiach Web Service: Windows Communication Foundation (WCF), SOAP, WS-*, REST, AJAX. Prelegent na konferencji <a href=\"http://buildwindows.com/\">build 2013</a>. Odszedł z Microsoft, aby rozkręcić własny biznes: <a href=\"http://mobilechapters.com\">http://mobilechapters.com</a>.",
                Photo = "tomasz_janczuk.jpg"
            };

            var speaker4 = new Speaker
            {
                Id = 4,
                Name = "Filip Wojcieszyn",
                About = "MVP, <a href=\"http://www.strathweb.com/\">blogger</a>, autor, aktywny członek społeczności Open Source (m.in. koordynator <a href=\"http://scriptcs.net/\">scriptcs</a> i <a href=\"https://github.com/WebApiContrib\">WebAPIContrib</a>). Członek ASP.NET Web API Advisory Board. Doświadczony w tworzeniu dużych aplikacji webowych w Polsce, Wielkiej Brytanii, Finlandii, Kanadzie. Obecnie mieszka w Szwajcarii i pracuje w Arcmedia AG. Dostępny na Twitterze jako <a href=\"http://twitter.com/filip_woj\">@@filip_woj</a>.",
                Photo = "filip_woj.jpg"
            };

            var speaker5 = new Speaker
            {
                Id = 5,
                Name = "Jakub Gutkowski",
                About = "MVP oraz <a href=\"http://blog.gutek.pl/\">blogger</a>. Absolwent Polsko-Japońskiej Wyższej Szkoły Technik Komputerowych w Warszawie nie potrafiący zagrzać sobie miejsca, więc teraz grzeje – zdalnie bo mu tak łatwiej, raz w kawiarniach, raz domu. Daje mu to okazję bawić się zawodowo różnymi technologiami i wieloma językami, choć próbuje być cool i rubinem też się bawi.",
                Photo = "jakub_gutkowski.png"
            };

            var speaker6 = new Speaker
            {
                Id = 6,
                Name = "Michał Łusiak",
                About = "",
                Photo = "michal_lusiak.jpg"
            };

            var speaker7 = new Speaker
            {
                Id = 7,
                Name = "Barbara Fusińska",
                About = "Basia pracowała w małej, średniej oraz dużej firmie, pełniąc role zarówno programistki, architekta, jak i kierownika. Od samego początku związana jest z platformą .NET, tworząc najpierw aplikacje desktopowe, a następnie webowe. Obecnie szuka inspiracji by rozpoczac nowa przygodę, jeżdzi na koferencje i <a href=\"http://barbarafusinska.com/\">blogguje</a>. Jest zwolennikiem współodpowiedzialności za wyniki pracy zespołu oraz teorii mówiącej, że to co tworzy grupa jest większe niż suma wyników poszczególnych osób. Żywiołowo reaguje na hasło rozwój we wszystkich odmianach - szkolenia, konferencje, zwykle i niezwykle rozmowy. Wciąż szuka okazji, by odkrywać potencjał drzemiący w każdym człowieku.",
                Photo = "barbara_fusinska.jpg"

            };

            var speaker8 = new Speaker
            {
                Id = 8,
                Name = "Patryk Góralowski",
                About = "",
                Photo = "patryk_goralowski.jpg"
            };


            var session1 = new Session
            {
                Id = 1,
                Time = "15:00 - 16:00",
                Title = "Testy jednostkowe w .NET",
                Speaker = speaker1,
                About = "Podczas sesji zaprezentowane zostanie pragmatyczne podejście do pisania testów jednostkowych w .NET. Teoria w połączeniu z praktyką zademonstrują dlaczego automatyczne testowanie oprogramowania jest niezmiernie ważne oraz... jak robić to bezboleśnie."
            };

            var session2 = new Session
            {
                Id = 2,
                Time = "16:00 - 17:00",
                Title = "Windows Phone 8 Tips & Tricks",
                Speaker = speaker2,
                About = "Windows Phone to dynamicznie rozwijająca się platforma, która zdobywa coraz większą rzeszę zwolenników i programisów. Okazuje się, że posiada również pewne arkana, o których nie wszyscy wiedzą, a które pozwalają tworzyć lepsze i bardziej przyjazne użytkownikom aplikacje. Dołącz się do konreferncji i przekonaj co jeszcze warto wiedzieć o Windows Phone."
            };

            _speakers.Add(speaker1);
            _speakers.Add(speaker2);
            _speakers.Add(speaker3);
            _speakers.Add(speaker4);
            _speakers.Add(speaker5);
            _speakers.Add(speaker6);
            _speakers.Add(speaker7);
            _speakers.Add(speaker8);

            //_sessions.Add(session1);
            //_sessions.Add(session2);
        }

        public List<Session> Sessions { get { return _sessions; } private set { _sessions = value; } }
        public List<Speaker> Speakers { get { return _speakers; } private set { _speakers = value;  } }
    }
}