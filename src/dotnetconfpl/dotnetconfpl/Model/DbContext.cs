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
                About = "MVP i najpopularniejszy blogger w polskim środowisku .NET. Miłośnik testów jednostkowych, Gita i Resharpera, zatwardziały wróg TFSa i Sharepointa. Z zawodu programista/architekt .NET w firmie Ultrico. Wcześniej pracował w firmie Predica. Przez pewien czas był także Freelancerem. Ponadto jest dwukrotnym finalistą ImagineCup i byłym redaktorem CodeGuru.pl.",
                Photo = "maciej_aniserowicz.jpg"
            };

            var speaker2 = new Speaker
            {
                Id = 2,
                Name = "Maciej Grabek",
                About = "MVP, blogger, głównie zajmuje się platformą Windows Phone. Prelegent na Microsoft Technology Summit w 2011 i 2012 roku, redaktor CodeGuru.pl, współtwórca serii webcastów poświęconych technologii Windows Phone 7 oraz Windows Phone 8. Ponadto współzałożyciel Toruńskiej Grupy Developerów .NET. Zajmuje się .NETem od czasów studiów i wersji 1.1.",
                Photo = "maciej_grabek.jpg"
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
            _sessions.Add(session1);
            _sessions.Add(session2);
        }

        public List<Session> Sessions { get { return _sessions; } private set { _sessions = value; } }
        public List<Speaker> Speakers { get { return _speakers; } private set { _speakers = value;  } }
    }
}