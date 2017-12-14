using System.Collections.Generic;

namespace dotnetconfpl.Model
{
    public class DbContext
    {
        List<Session> _sessions = new List<Session>();
        List<Speaker> _speakers = new List<Speaker>();

        public DbContext()
        {
            var marcin_zajkowski = new Speaker
            {
                Id = 1,
                Name = "Marcin Zajkowski",
                About = "Trener i Certyfikowany Master Umbraco @ The Cogworks, Czarodziej od Treśći i Wiedzy, Wódz Trenerów / PedagoGEEK @ WOW School, Ja - bloger @ udfnd.pl",
                Photo = "marcin_zajkowski2017.jpeg"
            };

            var adam_furmanek = new Speaker
            {
                Id = 2,
                Name = "Adam Furmanek",
                About = "Absolwent Informatyki na WIEiT na AGH, obecnie programista w firmie Amazon w Seattle, blogger i moderator forum Matematyka.pl. Zainteresowany programowaniem systemowym, aplikacjami desktopowymi, rozwiązaniami mobilnymi i systemami rozproszonymi. Zawsze dąży do pełnego zrozumienia wewnętrznych mechanizmów używanych technologii, nie boi się asemblera i generowania kodu maszynowego w locie. W wolnych chwilach prowadzi techniczny blog „Random IT Utensils” pod adresem https://blog.adamfurmanek.pl , gdzie opisuje szczegóły implementacyjne platformy .NET, zastosowania całkowitoliczbowego programowania liniowego (ILP), sposoby konstrukcji kompilatora i historie z debugowania systemów spotykanych w pracy.",
                Photo = "adam_furmanek2017.jpg"
            };

            var krzysztof_owsiany = new Speaker
            {
                Id = 3,
                Name = "Krzysztof Owsiany",
                About = "Pasjonat informatyki i programowania od dziecka. Działający obecnie głównie w obszarze technologii .NET. Zwolennik TDD, DDD i Clean Code GameDev. Nieustannie  rozwijający swój kunszt developerski. Nie stroni także od innych języków jak: JAVA, PHP, JavaScript. Młody niespełna  roczny blogger, stawiający swoje pierwsze kroki na scenie.",
                Photo = "krzysztof_owsiany2017.png"
            };

            var piotr_stapp = new Speaker
            {
                Id = 4,
                Name = "Piotr Stapp",
                About = "Programista, inżynier, rzemieślnik, projektant i rowerzysta. Korzysta z każdej technologii, która prowadzi do celu. Wierzy w ludzi, a nie w papiery. Jest wyznawcą DevOps i wszelkiej automatyzacji. Jak przystało na człowieka inteligentnego, prowadzi bloga – o tyle wyjątkowego, że regularnie pojawiają się tam nowe teksty: http://stapp.space/ Do niedawna Ekspert IT w mBanku. Obecnie współtworzy nowy fintech – FinAi, w którym pracuje nad zamianą rzeczy skomplikowanych na proste. A to czasem bywa trudne.",
                Photo = "piotr_stapp2017.jpeg"
            };

            var marian_dziubak = new Speaker
            {
                Id = 5,
                Name = "Marian Dziubiak",
                About = "Student Informatki III roku na Uniwersytecie Warszawskim, Microsoft Student Partner i lider Grupy .NET MIMUW. W blogosferze od dwóch lat pisze o swojej przygodzie z IT, a czasem wpada na meetupy i konferencje. Po za światem informatyki, Marian jest zawodnikiem Warsaw Mermaids - warszawskiej drużyny Quidditcha, a także Dyrektorem ds. Gameplay w Polskiej Lidze Quidditcha.",
                Photo = "marian_dziubak2017.jpg"
            };

            var damian_antonowicz = new Speaker
            {
                Id = 6,
                Name = "Damian Antonowicz",
                About = "Obecnie certyfikowany programista Xamarin tworzący aplikacje mobilne na platformy Android oraz iOS. Związany od wielu lat z platformą .NET i ekosystemem Microsoft, a szczególnie z systemem Windows Phone, na który tworzył aplikacje jeszcze przed jego premierą. Podczas swojej kariery zawodowej pracował nad różnorodnymi aplikacjami związanymi z bankowością, finansami, zdrowiem publicznym, motoryzacją. Pasjonat nowych technologii, bloger, prelegent i fan whisky.",
                Photo = "damian_antonowicz2017.png"
            };

            var dariusz_pawlukiewicz = new Speaker
            {
                Id = 7,
                Name = "Dariusz Pawlukiewicz",
                About = "Programista pasjonat. Prowadzi blog Forever F[r]ame oraz podcast programistyczny DevReview. Uwielbia poznawać nowe, ciekawe technologie i nie boi się używać ich w swoich projektach. Fan TypeScript oraz frameworku Aurelia. Entuzjasta DDD, CQRS i Event Sourcingu. Na co dzień pracuje, jako Full Stack Developer w firmie Connectis_.",
                Photo = "dariusz_pawlukiewicz2017.jpg"
            };

            var lukasz_pyrzyk = new Speaker
            {
                Id = 8,
                Name = "Łukasz Pyrzyk",
                About = "Senior Fullstack Cloud Developer w szwajcarskiej firmie Sonova. Organizator .NET Core Tour i członek Dotnetos. Fan wydajności i zabawy bajtami. Okazjonalny blogger i kontrybutor open source.",
                Photo = "lukasz_pyrzyk2017.jpg"
            };

            var session1 = new Session
            {
                Id = 1,
                Time = "14:00 - 15:00",
                Title = "Co nowego w C#7, 7.x i....8!",
                Speaker = marcin_zajkowski,
                About = "Wielu programistów .NET nie przywykła (bądź nawet nie próbowała przywyknąć - #smuteczek) do stosowania wszystkich udogodnień, które udostępnione zostały nam w wersji 6 języka C#. Tymczasem na mapie wydanych wersji widnieje już wersja 7, 7.1 i 7.2, a na Githubie trwają burzliwe dyskusje na temat zakresu zmian w C# 8! Co nowego szykują nam twórcy języka? Czy powinniśmy obawiać się nadchodzących zmian i wyjścia poza strefę naszych programistycznych nawyków? Czy powinniśmy refaktoryzować nasze projekty, aby być zawsze na bieżąco w ramach platformy? Na te i inne pytania odpowiemy w trakcie tej prezentacji.",
                YoutubeUrl = string.Empty
            };

            var session2 = new Session
            {
                Id = 2,
                Time = "15:00 - 16:00",
                Title = "CCC - Cloud, Continious, Configuration",
                Speaker = piotr_stapp,
                About = "CCC na pierwszy rzut oka kojarzy się z firmą obuwniczą, ale o niej w tej sesji nic nie będzie. Co innego chmura tu skojarzenia idą dużo dalej. W większości przypadków jest to marzenie dla deweloperów, architektów czy nawet PM. Cały zestaw usług 'As A Service' + serverless to cała masa pomysłów. Jednak zarządzanie i wdrażanie ich nie jest aż tak proste. Dla dużej ilości usług i aplikacji konfiguracja prosta nie jest. Szczególnie, że maszyny wirtualne są bleee i fuj, a usług do wyboru bez liku. W trakcie sesji pokażę jak to robimy w FinAi (młodym statrtup z kategorii FinTech), w prawdziwej chmurze (tu wystąpi Azure), z punktu widzenia deweloperów (bo administratorów za bardzo u nas nie ma), na naszym CI (w głównej roli Visual Studio Team Services).",
                YoutubeUrl = string.Empty
            };

            var session3 = new Session
            {
                Id = 3,
                Time = "16:00 - 17:00",
                Title = "Ile (nie) wiesz o strukturach w .NET",
                Speaker = lukasz_pyrzyk,
                About = "Kiedy ostatnio stworzyłeś nową strukturę pisząc aplikację w .NET? Wiesz do czego wykorzystywać struktury i jak mogą one zwiększyć wydajność Twojego programu? W prezentacji pokażę czym charakteryzują się struktury, jak dużo różni je od klas oraz opowiem o kilku ciekawych eksperymentach.",
                YoutubeUrl = string.Empty
            };

            var session4 = new Session
            {
                Id = 4,
                Time = "17:00 - 18:00",
                Title = "Grywalizacja + projektowanie na wybranym przykładzie.",
                Speaker = krzysztof_owsiany,
                About = "Grywalizacja – jak sama nazwa wskazuje wiąże się z grami komputerowymi. W czasie prezentacji przedstawię czym jest grywalizacja. Gdzie można ją użyć. Jakie korzyści niesie ze sobą ten ciekawy mechanizm wydarty prosto ze światka gier komputerowych. Zaprezentuję zestaw mechanizmów składających się na mechanikę gier, jakie można wykorzystać budując oprogramowanie komputerowe. Omówię kilka przykładów wykorzystania mechaniki gier w codziennym życiu. Na koniec pokuszę się o zaprojektowanie mechanizmu grywalizacji na prostym przykładzie.",
                YoutubeUrl = string.Empty
            };

            var session5 = new Session
            {
                Id = 5,
                Time = "18:00 - 19:00",
                Title = "Porównanie MVC w F# z Suave oraz w C# z ASP.NET Core",
                Speaker = marian_dziubak,
                About = "Odświeżymy sobie informację o wzorcu projektowym Model-View-Controller oraz przeanalizujemy aplikację napisaną w dwóch odmiennych środowiskach: w F# z biblioteką Suave oraz w C# z ASP.NET Core. Przejdziemy od konfiguracji środowiska, przez modele, widoki, kontrolery, aż do podłączenia do naszej aplikacji bazy danych. Po prezentacji będziecie posiadali wiedzę na temat tego jak napisać prostą aplikację Suave lub ASP.NET Core oraz jak niektóre konstrukcje języków C# i F# przyczyniają się do używania określonych wzorców programistycznych.",
                YoutubeUrl = string.Empty
            };

            var session6 = new Session
            {
                Id = 6,
                Time = "19:00 - 20:00",
                Title = "Ręczne zarządzanie pamięcią w .NET",
                Speaker = adam_furmanek,
                About = "Obiekty referencyjne na stercie, obiekty wartościowe na stosie — to typowa odpowiedź na pytanie o położenie w pamięci alokowanych instancji. Ale co dokładnie na temat struktury pamięci mówi standard .NET? Czy wymaga konkretnego zachowania w tym obszarze, czy może istnieją mechanizmy pozwalające nam przejąć kontrolę nad alokacją? Czy da się przenieść obiekt referencyjny na stos? A jeżeli tak, to co jeszcze można zrobić w języku, w którym tworzeniem i niszczeniem obiektów zajmuje się platforma? W trakcie prezentacji pokażę, jak ręcznie zaalokować obiekt w dowolnym miejscu i napisać własny operator new.Będzie trochę asemblera, podglądania zrzutów pamięci, słów kluczowych nierozpoznawanych przez ReSharpera, a wszystko to w C# — języku, w którym na pierwszy rzut oka nie da się tego zrobić.",
                YoutubeUrl = string.Empty
            };

            var session7 = new Session
            {
                Id = 7,
                Time = "20:00 - 21:00",
                Title = "Xamarin - jak się do tego zabrać?",
                Speaker = damian_antonowicz,
                About = "Zastanawiałeś się nad tym jak tworzyć efektywniej natywne mobilne aplikacje cross-platform? Podczas tej sesji dowiesz się jak może Ci w tym pomóc znajomość Xamarina, którego popularność stale rośnie. Dowiesz się czym jest Xamarin i jak tak naprawdę działa oraz kiedy warto go użyć. Podzielę się z Tobą nabytym doświadczeniem, najlepszymi praktykami oraz wskażę kierunek, w którym możesz dalej się rozwijać.",
                YoutubeUrl = string.Empty
            };

            var session8 = new Session
            {
                Id = 8,
                Time = "21:00 - 22:00",
                Title = "It's all about the state, czyli co skrywa async/await w C#?",
                Speaker = dariusz_pawlukiewicz,
                About = "Przez ostatnie lata programowanie asynchroniczne mocno się spopularyzowało, a jego użycie np. przy wykonywaniu żądań HTTP nikogo już nie dziwi. Język C# umożliwia nam bardzo prostą i przyjemną implementację kodu asynchronicznego przy wykorzystaniu async/await. Czy aby na pewno? Na sesji uczestnicy zostaną zapoznani z mechaniką async/await, aby następnie zanurkować prosto do świata kodu pośredniego (Intermediate Language) gdzie dowiedzą się jak ciężko musi napracować się kompilator, aby życie programisty było łatwe i przyjemne.",
                YoutubeUrl = string.Empty
            };

            _speakers.Add(marcin_zajkowski);
            _speakers.Add(adam_furmanek);
            _speakers.Add(krzysztof_owsiany);
            _speakers.Add(piotr_stapp);
            _speakers.Add(marian_dziubak);
            _speakers.Add(damian_antonowicz);
            _speakers.Add(dariusz_pawlukiewicz);
            _speakers.Add(lukasz_pyrzyk);

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
        public List<Speaker> Speakers { get { return _speakers; } private set { _speakers = value; } }
    }
}
