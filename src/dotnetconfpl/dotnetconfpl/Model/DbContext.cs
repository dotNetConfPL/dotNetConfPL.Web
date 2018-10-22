﻿using System.Collections.Generic;

namespace dotnetconfpl.Model
{
    public class DbContext
    {
        public DbContext()
        {
            var adam_furmanek = new Speaker
            {
                Id = 1,
                Name = "Adam Furmanek",
                About = "Obecnie pracuję w Amazonie w dziale Prime Video, gdzie zajmuję się personalizacją rekomendacji dla użytkowników, uczeniem maszynowym i szeroko rozumianym big data. Wcześniej przez wiele lat pracowałem jako programista .NET, nieobcy był mi także fullstack JS (React, Angular, node), aplikacje mobilne (iOS), a karierę zaczynałem jako programista Javy. Ukończyłem Informatykę na AGH ze specjalizacją w systemach rozproszonych i sieciach komputerowych.\r\n\r\nW pracy zawsze interesuje mnie pełne zrozumienie platformy, systemu operacyjnego, frameworków i bibliotek, dlatego często dekompiluję binarki, debuguję kod maszynowy i schodzę na poziom maszyny wirtualnej lub systemu operacyjnego. W wolnych chwilach rozwijam bibliotekę do ILP, prowadzę bloga Random IT Utensils i gram na keyboardzie.",
                Photo = "adam_furmanek2017.jpg"
            };
            var krzysztof_owsiany = new Speaker
            {
                Id = 2,
                Name = "Krzysztof Owsiany",
                About = "Programowaniem pasjonuję się od ćwierćwiecza. Jako dzieciak zakochałem się w programowaniu. Od tego czasu miałem wiele różnych związków językowo-technologicznych. Obecnie najmocniej rozwijam się w obszarach .NET. Prowadzę własną firmę GemuStudio. Pracuję obecnie głównie jako podwykonawca i dostarczam oprogramowanie lub moduły oprogramowania Contact Center. Wcześniej przez wiele lat rozwijałem system do monitorowania/sterowania, analizy, prezentacji obiektów telemetrycznych z branży WOD-KAN.\r\n\r\nPo godzinkach zawsze coś knuję:\r\n\t• Blog: http://mrdev.pl, \r\n\t• Podcast: http://mrdev.pl/after-conf,\r\n\t• Wystąpienia: http://mrdev.pl/prelekcje,\r\nWłasne projekty: http://mrdev.pl/thenv.",
                Photo = "krzysztof_owsiany2018.jpg"
            };

            var michal_jankowski = new Speaker
            {
                Id = 3,
                Name = "Michał Jankowski",
                About = "Michał - Microsoft MVP Azure, architekt, programista, projektant, lider zespołu, a w wolnym czasie trener. Przygodę z programowaniem zaczął ponad dwadzieścia lat temu od Basic’a i Assemblera dla komputerów 8-bitowych. Od ponad dziesięciu lat uczestniczy w tworzeniu oprogramowania na platformę .NET dla największych światowych firm. W tym czasie brał udział w wytwarzaniu aplikacji desktopowych, mobilnych oraz webowych pełniąc różne role. Obecnie specjalizuje się w rozwiązaniach chmurowych – Microsoft Azure, a w szczególności powiązanych z trendem Serverless.\r\nPrywatnie miłośnik podróży oraz fotografii. W wolnym czasie prowadzi bloga www.jankowskimichal.pl, twórca rozwiązań open-source oraz aplikacji mobilnych.",
                Photo = "michal_jankowski2018.jpeg"
            };

            var joanna_lamch = new Speaker
            {
                Id = 4,
                Name = "Joanna Lamch",
                About = "Programistka, fanboy Microsoftu z iPadem w ręku, kociara. W branży IT od 15 lat w obrębie Microsoft Technology Stack. Koder C# z doświadczeniem w wielu technologiach na różne platformy docelowe. Obecnie developer w projektach mobilnych (Xamarin). Zwolenniczka Defensive Coding, SOLID, uczenia poprzez mentoring i ułatwiania życia programisty z wykorzystaniem dobrodziejstw współczesnego DevOps\'u.",
                Photo = "joanna_lamch2018.jpg"
            };

            var speaker5 = new Speaker
            {
                Id = 5,
                Name = "TBA",
                About = "",
                Photo = "unknown.jpg"
            };

            var speaker6 = new Speaker
            {
                Id = 6,
                Name = "TBA",
                About = "",
                Photo = "unknown.jpg"
            };

            var speaker7 = new Speaker
            {
                Id = 7,
                Name = "TBA",
                About = "",
                Photo = "unknown.jpg"
            };

            Speakers.Add(adam_furmanek);
            Speakers.Add(krzysztof_owsiany);
            Speakers.Add(michal_jankowski);
            Speakers.Add(joanna_lamch);
            Speakers.Add(speaker5);
            Speakers.Add(speaker6);
            Speakers.Add(speaker7);

            var session1 = new Session
            {
                Id = 1,
                Time = "14:00 - 15:00",
                Title = "3… 2… 1… Lift off… CosmosDB",
                Speaker = michal_jankowski,
                About = "Azure CosmosDB jest jednym z najgorętszych tematów w ostatnim czasie. Technologia ta, baza danych NoSQL, pozwala na budowanie wysoko skalowalnej, rozproszonej bazy danych o prawie natychmiastowym dostępie do danych. Możliwości tego rozwiązania są olbrzymie. \r\n\r\nA czy Ty znasz jego potencjał?\r\n\r\nJeśli nie, to ta sesja jest dla Ciebie. W jej trakcie zostaną przedstawione główne funkcjonalności Azure CosmosDB. Zastanowimy się, czy różni się ona od bazy relacyjnej. Jak wpływa to na jej projektowanie. Jakie są jej mocne i słabe strony. A przede wszystkim poznamy możliwości jej zastosowania przy budowaniu wysokowydajnych aplikacji.",
            };

            var session2 = new Session
            {
                Id = 2,
                Time = "15:00 - 16:00",
                Speaker = joanna_lamch,
                Title = "WebAssembly and .NET",
                About = "WebAssembly będą następną dużą rzeczą w świecie IT. Już teraz nie tylko jest o nich głośno ale zaczynają zmieniać oblicze aplikacji webowych.  Aplikacje webowe to przecież JavaScrip co to ma z .NETem i C# wspólnego? Microsoft eksperymentuje z razorem w przeglądarce czyli Blazor\'em. Jednak nie tylko Blazor możliwy jest do uruchomienia jako WebAssembly, mamy też Ooui oraz Uno, a wszystko to oparte na Mono. Czyli .NET w przeglądarce i WebAssembly w pigułce. "
            };

            var session3 = new Session
            {
                Id = 3,
                Time = "16:00 - 17:00",
                Speaker = speaker5,
                Title = "TBA"
            };

            var session4 = new Session
            {
                Id = 4,
                Time = "17:00 - 18:00",
                Speaker = krzysztof_owsiany,
                Title = "IL — między piekłem a niebem.",
                About = "Czym jest IL? Wykorzystanie narzędzi do analizy pisanego kodu. Nie zabraknie też powiązanych tematów: JIT, CLR, CTS, CLS, class, struct, boxing, kompilacja, dekompilacja, mnemoniki, manifest, metadane."
            };

            var session5 = new Session
            {
                Id = 5,
                Time = "18:00 - 19:00",
                Speaker = speaker6,
                Title = "TBA"
            };

            var session6 = new Session
            {
                Id = 6,
                Time = "19:00 - 20:00",
                Speaker = speaker7,
                Title = "TBA"
            };

            var session7 = new Session
            {
                Id = 7,
                Time = "20:00 - 21:00",
                Title = "Bebechy wyjątków",
                Speaker = adam_furmanek,
                About = "Wiesz jak rzucić i złapać wyjątki, ale czy wiesz, jak są one zbudowane pod spodem? Czy znasz SEH, VEH, VCH, SJLJ i inne technologie w Windowsie? Czy wiesz, po co C# wprowadził exception filters i jak złapać StackOverflowException?\r\n\r\nW trakcie prezentacji poznamy szczegóły implementacyjne mechanizmów do łapania wyjątków. Zobaczymy kod z wielu języków, zarówno z poziomu procesora i WinAPI, jak również z C++, IL czy C#. Pokażę także kiedy bloki finally nie są wykonywane, jak ratować się w przypadku poważnych błędów w dostępie do pamięci, a także jak w C# złapać absolutnie wszystko, nawet StackOverflowException."
            };

            Sessions.Add(session1);
            Sessions.Add(session2);
            Sessions.Add(session3);
            Sessions.Add(session4);
            Sessions.Add(session5);
            Sessions.Add(session6);
            Sessions.Add(session7);
        }

        public List<Session> Sessions { get; } = new List<Session>();
        public List<Speaker> Speakers { get; } = new List<Speaker>();
    }
}
