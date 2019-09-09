using System.Collections.Generic;

namespace dotnetconfpl.Model
{
    public class DbContext
    {
        public DbContext()
        {
            var piotrAndDarek = new Speaker
            {
                Id=1,
                Name = "Piotr Gankiewicz & Dariusz Pawlukiewicz",
                About = @"Piotr:

                        Microsoft MVP,
                        trener Bottega IT Minds,
                        a na co dzień inżynier oprogramowania rozwijający klienta sieci Ethereum Blockchain w Nethermind.Zwolennik Domain Driven Design,
                        CQRS oraz systemów rozproszonych.Kontrybutor open source i prelegent na konferencjach branżowych.Współtwórca platformy DevMentors.io.

                        Dariusz:
                        Absolwent wydziału Cybernetyki na Wojskowej Akademii Technicznej.Microsoft MVP. Miłośnik języka C# oraz platformy .NET Core. Entuzjasta DDD, CQRS oraz wszelkich zagadnień związanych z systemami rozproszonymi. Regularnie prowadzi bloga foreverframe.net, a okazjonalnie pojawia się na spotkaniach oraz konferencjach programistycznych w roli prelegenta. Współtwórca platformy DevMentors.io.
                ",
                Photo = "unknown.jpg"
            };

            var joannaLamch = new Speaker
            {
                Id = 2,
                Name = "Joanna Lamch",
                About = @"Koderka pełną piersią, fangir Microsoftu z iPadem w ręku, kociara. W branży IT od wielu lat zawsze w okolicach C# oraz technologi Microsoft.
                        Zwolenniczka Defensive Coding,
                        SOLID,
                        uczenia poprzez mentoring,
                        samorozwoju i kultury DevOps.Community lover,
                        wspierająca Gruba.IT,
                        współorganizatorka Śląskiej Grupy Microsoft.Blogger and speaker wannabe. ",
                Photo = "joanna_lamch_squere.jpg"
            };

            var piotrStapp = new Speaker
            {
                Id = 3,
                Name = "Piotr Stapp",
                About = @"Programista, inżynier, rzemieślnik, projektant i rowerzysta.
                        Korzysta z każdej technologii, która prowadzi do celu.
                        Wierzy w ludzi, a nie w papiery. Jest wyznawcą DevOps i wszelkiej automatyzacji.
                        Jak przystało na człowieka inteligentnego, prowadzi bloga – https://stapp.space/
                        Od czerwca 2018 znany jako 'główny' dotnetomaniak.
                        Na codzień główny architekt w FinAi oraz Microsoft MVP.",
                Photo = "piotr_stapp2017.jpeg"
            };

            var kamilGrzybek = new Speaker
            {
                Id = 4,
                Name = "Kamil Grzybek",
                About =
                    @"Architekt, Team Leader oraz programista związany z technologią .NET od ponad 11 lat. Absolwent Politechniki Warszawskiej i kierunku Informatyka o specjalizacji Inżynieria Oprogramowania. Zwolennik podejścia Software Craftsmanship, Agile, automatyzacji, Czystego Kodu oraz pragmatycznego rozwiązywania problemów zgodnie z ich klasą. Pasjonat tematów związanych z architekturą oprogramowania i projektowaniem systemów. Entuzjasta i praktyk Domain-Driven Design. Przemyślenia dotyczące wytwarzania oprogramowania opisuje na swoim blogu http://www.kamilgrzybek.com i Twitterze: @kamgrzybek.

                    Związany z firmą ITSG Global, gdzie jako architekt, programista i konsultant odpowiedzialny jest za wytwarzanie oprogramowania dla firm z branży finansowej, medycznej i Big Data.

                    Prywatnie - mąż, tata ukochanej córeczki, opiekun niesfornego psa, biegacz - amator i pasjonat samodoskonalenia żyjący zgodnie z Sokratesową dewizą - 'wiem, że nic wiem'.",
                Photo = "kamil_grzybek.jfif"
            };

            var januszNowak = new Speaker
            {
                Id = 5,
                Name = "Janusz Nowak",
                About =
                    @"Senior software developer with 12 years of experience specialized on Microsoft and Web technologies, enterprise solutions architecture, programming and Azure Cloud computing, Paas, Saas, focused on Application Life Cycle Management.I have worked with multiple Microsoft Technologies starting from .NET 1.1 and VS2003 up to .NET 4.5 and VS2017 , Microsoft SQL Server, SharePoint Server, Team Foundation Server, Visual Studio Team Services keeping the big and small picture what is going on.",
                Photo = "unknown.jpg"
            };

            var pawelHaracz = new Speaker
            {
                Id = 6,
                Name = "Paweł Haracz",
                About =
                    @"Pasjonat rozwiązań chmurowych. Mający głowę w chmurach. Uczestnik meetupow, konferencji. Zainteresowaniem do architektury mikroserwisowej jak rownież do serverlessowej. Jego znakiem rozpoznawczym jest słowo „Awesome”",
                Photo = "pawel_haracz.jpg"
            };



            Speakers.Add(piotrAndDarek);
            Speakers.Add(joannaLamch);
            Speakers.Add(piotrStapp);
            Speakers.Add(kamilGrzybek);
            Speakers.Add(januszNowak);
            Speakers.Add(pawelHaracz);


            var session1 = new Session {Speaker = piotrAndDarek, Title= "Convey - prosty przepis na mikroserwisy" };
            var session2 = new Session {Speaker = joannaLamch, Title = "Internet of Things on Azure" };
            var session3 = new Session {Speaker = piotrStapp, Title = "Orkiestracja to zło (konieczne)" };
            var session4 = new Session {Speaker = kamilGrzybek, Title = "From Anemic to Rich Domain Model: Refactoring live session." };
            var session5 = new Session {Speaker = januszNowak, Title = "Use Azure DevOps to depoly Azure Function in Docker on Raspberry Pi." };
            var session6 = new Session {Speaker = pawelHaracz, Title = "Jak Event-driven Development pozwolił zbudować skalowalny system" };

            Sessions.Add(session1);
            Sessions.Add(session2);
            Sessions.Add(session3);
            Sessions.Add(session4);
            Sessions.Add(session5);
            Sessions.Add(session6);
        }

        public List<Session> Sessions { get; } = new List<Session>();
        public List<Speaker> Speakers { get; } = new List<Speaker>();
    }
}
