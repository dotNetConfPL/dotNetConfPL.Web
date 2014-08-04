﻿using System;
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
            var maciej_aniserowicz = new Speaker
            {
                Id = 1,
                Name = "Maciej Aniserowicz",
                About = "MVP i najpopularniejszy <a href=\"http://www.maciejaniserowicz.com/\">blogger</a> w polskim środowisku .NET. Miłośnik testów jednostkowych, Gita i Resharpera, zatwardziały wróg TFSa i Sharepointa. Z zawodu programista/architekt .NET w firmie Ultrico. Wcześniej pracował w firmie Predica. Przez pewien czas był także Freelancerem. Ponadto jest dwukrotnym finalistą ImagineCup i byłym redaktorem <a href=\"http://codeguru.geekclub.pl/\">CodeGuru.pl</a>.",
                Photo = "maciej_aniserowicz.jpg"
            };

            var barbara_fusinska = new Speaker
            {
                Id = 2,
                Name = "Barbara Fusińska",
                About = "Basia pracowała w małej, średniej oraz dużej firmie, pełniąc role zarówno programistki, architekta, jak i kierownika. Od samego początku związana jest z platformą .NET, tworząc najpierw aplikacje desktopowe, a następnie webowe. Obecnie szuka inspiracji by rozpoczac nowa przygodę, jeżdzi na koferencje i <a href=\"http://barbarafusinska.com/\">blogguje</a>. Jest zwolennikiem współodpowiedzialności za wyniki pracy zespołu oraz teorii mówiącej, że to co tworzy grupa jest większe niż suma wyników poszczególnych osób. Żywiołowo reaguje na hasło rozwój we wszystkich odmianach - szkolenia, konferencje, zwykle i niezwykle rozmowy. Wciąż szuka okazji, by odkrywać potencjał drzemiący w każdym człowieku.",
                Photo = "barbara_fusinska.jpg"

            };

            var patryk_goralowski = new Speaker
            {
                Id = 3,
                Name = "Patryk Góralowski",
                About = "18 lat w sprzedaży; 10 lat w marketingu, od 8 lat prowadzi warsztaty, szkolenia, moderowane sesje strategiczne i coachingowe grupowe oraz indywidualne. Prelegent, moderator i wykładowca. Właściciel firmy <a href=\"http://tristantresar.com\">tristantresar.com</a>. Certyfikowany trener i konsultant SenseMaking® w firmie Freemen. Dyrektor ds. zarządzania konsumenckimi kategoriami produktów Microsoft. Certyfikowany trener i doradca w szkole sprzedaży Jeffrey' a Gitomer'a. Doradca ds. kariery w Chartered Institute of Marketing.",
                Photo = "patryk_goralowski.jpg"
            };

            var maciej_grabek = new Speaker
            {
                Id = 4,
                Name = "Maciej Grabek",
                About = "MVP, <a href=\"http://maciejgrabek.com/\">blogger</a>, głównie zajmuje się platformą Windows Phone. Prelegent na <a href=\"http://www.mtskonferencja.pl/\">Microsoft Technology Summit</a> w 2011 i 2012 roku, redaktor <a href=\"http://codeguru.geekclub.pl/\">CodeGuru.pl</a>, współtwórca serii webcastów poświęconych technologii <a href=\"http://channel9.msdn.com/Series/Kurs-programowania-Windows-Phone-7\">Windows Phone 7</a> oraz <a href=\"http://channel9.msdn.com/Series/Tworzenie-aplikacji-dla-systemu-Windows-Phone-8\">Windows Phone 8</a>. Ponadto współzałożyciel <a href=\"http://wss.pl/group-134/Default.aspx\">Toruńskiej Grupy Developerów .NET</a>. Zajmuje się .NETem od czasów studiów i wersji 1.1.",
                Photo = "maciej_grabek.jpg"
            };

            var jakub_gutkowski = new Speaker
            {
                Id = 5,
                Name = "Jakub Gutkowski",
                About = "MVP oraz <a href=\"http://blog.gutek.pl/\">blogger</a>. Absolwent Polsko-Japońskiej Wyższej Szkoły Technik Komputerowych w Warszawie nie potrafiący zagrzać sobie miejsca, więc teraz grzeje – zdalnie bo mu tak łatwiej, raz w kawiarniach, raz domu. Daje mu to okazję bawić się zawodowo różnymi technologiami i wieloma językami, choć próbuje być cool i rubinem też się bawi.",
                Photo = "jakub_gutkowski.png"
            };

            var tomasz_janczuk = new Speaker
            {
                Id = 6,
                Name = "Tomasz Janczuk",
                About = "Do września 2013 pracownik Microsoftu w Redmond (USA). Ostatnio zajmował się Node.js, JavaScript i Windows Azure. Wcześniej pracował przy .NET Framework i Silverlight, a dokładniej przy technologiach Web Service: Windows Communication Foundation (WCF), SOAP, WS-*, REST, AJAX. Prelegent na konferencji <a href=\"http://buildwindows.com/\">build 2013</a>. Odszedł z Microsoft, aby rozkręcić własny biznes: <a href=\"http://mobilechapters.com\">http://mobilechapters.com</a>.",
                Photo = "tomasz_janczuk.jpg"
            };

            var michal_lusiak = new Speaker
            {
                Id = 7,
                Name = "Michał Łusiak",
                About = "",
                Photo = "michal_lusiak.jpg"
            };

            var filip_woj = new Speaker
            {
                Id = 8,
                Name = "Filip Wojcieszyn",
                About = "MVP, <a href=\"http://www.strathweb.com/\">blogger</a>, autor, aktywny członek społeczności Open Source (m.in. koordynator <a href=\"http://scriptcs.net/\">scriptcs</a> i <a href=\"https://github.com/WebApiContrib\">WebAPIContrib</a>). Członek ASP.NET Web API Advisory Board. Doświadczony w tworzeniu dużych aplikacji webowych w Polsce, Wielkiej Brytanii, Finlandii, Kanadzie. Obecnie mieszka w Szwajcarii i pracuje w Arcmedia AG. Dostępny na Twitterze jako <a href=\"http://twitter.com/filip_woj\">@filip_woj</a>.",
                Photo = "filip_woj.jpg"
            };


            var session1 = new Session
            {
                Id = 1,
                Time = "",
                Title = "GTD",
                Speaker = maciej_aniserowicz,
                About = ""
            };

            var session2 = new Session
            {
                Id = 2,
                Time = "",
                Title = "Xamarin",
                Speaker = maciej_grabek,
                About = ""
            };

            var session3 = new Session
            {
                Id = 3,
                Time = "",
                Title = "Node.js",
                Speaker = tomasz_janczuk,
                About = ""
            };

            var session4 = new Session
            {
                Id = 4,
                Time = "",
                Title = "Roslyn",
                Speaker = filip_woj,
                About = ""
            };

            var session5 = new Session
            {
                Id = 5,
                Time = "",
                Title = "JavaScript",
                Speaker = jakub_gutkowski,
                About = ""
            };

            var session6 = new Session
            {
                Id = 6,
                Time = "",
                Title = "Programowanie zorientowane aspektowo (AOP)",
                Speaker = barbara_fusinska,
                About = ""
            };

            var session7 = new Session
            {
                Id = 7,
                Time = "",
                Title = "Talent za 2 dolary. Skusisz się!",
                Speaker = patryk_goralowski,
                About = ""
            };

            var session8 = new Session
            {
                Id = 8,
                Time = "",
                Title = "F#",
                Speaker = michal_lusiak,
                About = ""
            };

            _speakers.Add(maciej_aniserowicz);
            _speakers.Add(barbara_fusinska);
            _speakers.Add(patryk_goralowski);
            _speakers.Add(maciej_grabek);
            _speakers.Add(jakub_gutkowski);
            _speakers.Add(tomasz_janczuk);
            _speakers.Add(michal_lusiak);
            _speakers.Add(filip_woj);            

            _sessions.Add(session1);
            _sessions.Add(session2);
            _sessions.Add(session3);
            _sessions.Add(session4);
            _sessions.Add(session5);
            _sessions.Add(session6);
            _sessions.Add(session7);
            _sessions.Add(session8);
        }

        public List<Session> Sessions { get { return _sessions; } private set { _sessions = value; } }
        public List<Speaker> Speakers { get { return _speakers; } private set { _speakers = value;  } }
    }
}