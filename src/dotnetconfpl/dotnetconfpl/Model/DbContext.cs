using System.Collections.Generic;

namespace dotnetconfpl.Model
{
    public class DbContext
    {
        List<Session> _sessions = new List<Session>();
        List<Speaker> _speakers = new List<Speaker>();

        public DbContext()
        {
            var piotr_stapp = new Speaker
            {
                Id = 1,
                Name = "Piotr Stapp",
                About = "Programista, inżynier, rzemieślnik, projektant i rowerzysta. Korzystający z każdej technologii, która prowadzi do celu. Wierzący w ludzi a nie w papiery. Wyznawca DevOps i automatyzacji wszelakiej Bloga ma i czasem na nim coś pisze http://stapp.space/ Na co dzień Ekspert IT w mBanku",
                Photo = "piotr_stapp.jpg"
            };

            var pawel_lukasik = new Speaker
            {
                Id = 2,
                Name = "Paweł Łukasik",
                About = "CxO w Octal Solutions. Pasjonat programowania, blogger, od czasu do czasu spiker, człowiek odpowiedzialny za dotnetomaniak.pl,  jeden z liderów Wrocławskiej Grupy .NET",
                Photo = "pawel_lukasik.jpeg"

            };

            var daniel_krzyczkowski = new Speaker
            {
                Id = 3,
                Name = "Daniel Krzyczkowski",
                About = "Pasjonat programowania na urządzenia mobilne. Prowadzi blog, na którym opisuje swoje doswiadczenia zwiazane z programowaniem aplikacji mobilnych: mobileprogrammer.pl Aktywny uczestnik społeczności związanej z technologiami firmy Microsoft(prelegent konferencji oraz warsztatów). Redaktor w magazynie: Warszawski Programista. Dzielenie się wiedza jest u Daniela nie tylko częścią pracy, lecz także sposobem na życie.",
                Photo = "DKrzyczkowski.jpg"
            };

            var szymon_kulec = new Speaker
            {
                Id = 4,
                Name = "Szymon Kulec",
                About = "Lider warszawskiej grupy .NET, prelegent, specjalista IT. Zainteresowany zarówno IT w skali makro (architektura), jak i mikro (performance, zrozumienie współczesnego hardware'u). Miłośnik DDD i zorientowania na zdarzenia a także dobrze wyseparowanych usług.",
                Photo = "szymon_kulec.jpg"
            };

            var marek_zając = new Speaker
            {
                Id = 5,
                Name = "Marek Zając",
                About = "Zawodowo programista .NET, hobbystycznie JAVA. Od 6 lat zajmuję się tworzeniem systemów informatycznych dla biznesu. Moimi głównymi zainteresowaniami jest architektura oprogramowania, systemy rozproszone, integracja systemów.",
                Photo = "marek_zajac.jpeg"
            };

            var dariusz_pawlukiewicz = new Speaker
            {
                Id = 6,
                Name = "Dariusz Pawlukiewicz",
                About = "Programista pasjonat. Za sprawą konkursu „Daj się poznać” świeżo upieczony blogger oraz podcaster. Uwielbia poznawać nowe, ciekawe technologie i nie boi się używać ich w swoich projektach. Fan TypeScript oraz frameworku Aurelia. Entuzjasta DDD, CQRS i Event Sourcingu. Na co dzień pracuje, jako Full Stack Developer w firmie Connectis_.",
                Photo = "dariusz_pawlukiewicz.jpg"
            };

            var szymon_warda = new Speaker
            {
                Id = 7,
                Name = "Szymon Warda",
                About = "Z .net od wersji 1.1, a z webem od czasów kiedy IE6 był tą lepszą przeglądarką. Przez pierwsze pół dnia główny architekt w ITMagination, drugie pół jako odpowiedzialny za jeden z większych projektów .net w Polsce. Tam architekt/team leader/developer/devops/człowiek od rozwiązywania problemów. Po pracy (trzecie pół) rozwijam pet project http://cookit.pl gdzie realizuję mokry sen nie jednego programisty - procesuję setki gigabajtów danych korzystając z tego co najlepiej pasuje do problemu (Bazy grafowe/ML/C#/F#/PowerShell/Lucene itp) Bywalec konferencji, prelegent Warszawskiej grupy .net., blogger (IndexOutOfRange.com)",
                Photo = "szymon_warda.jpg"
            };

            var session1 = new Session
            {
                Id = 1,
                Time = "15:00 - 16:00",
                Title = "Pogromcy mitów: HTTP/2 i wydajność",
                Speaker = piotr_stapp,
                About = "Wydajność webowa była, jest i będzie istotna. Wielu deweloperów pokłada nadzieje w HTTP / 2, który już wkrótce ma być powszechny. Jednakże, czy wszystkie problemy zostaną magicznie rozwiązane ? Zaczniemy od historii, dotkniemy tego co jest dzisiaj, a potem skupimy się na najbliższej przyszłości.Uwzględniając m.in: HTTP / 2, FLIF i WebP czy Google HTML/ CSS Style Guide. Kilka mitów i pseudo-faktów zostanie sprawdzonych i obalonych na żywo. Będzie niezła zabawa!",
                YoutubeUrl = ""
            };

            var session2 = new Session
            {
                Id = 1,
                Time = "16:00 - 17:00",
                Title = "Hackowanie ILa",
                Speaker = pawel_lukasik,
                About = "W codziennej pracy używamy .NETa kodując w C#, F# czy VB. Ale siedzący pod spodem IL daje nam trochę większe możliwości niż to co mamy dostępne na co dzień. W prezentacji pokażę przydatne, nieprzydatne oraz ciekawe możliwości które daje nam IL jeśli tylko pozwolimy sobie na jego poznanie.",
                YoutubeUrl = ""
            };

            var session3 = new Session
            {
                Id = 2,
                Time = "17:00 - 18:00",
                Title = "Universal Windows 10 Platform",
                Speaker = daniel_krzyczkowski,
                About = "Podczas prezentacji uczestnicy zostaną wprowadzeni w temat Uniwersalnej Platformy Windows 10. Będą mogli zdobyć wiedzę na temat tworzenia responsywnych aplikacji dla rożnych urządzeń z systemem Windows 10.",
                YoutubeUrl = ""
            };

            var session4 = new Session
            {
                Id = 3,
                Time = "20:00 - 21:00",
                Title = "Zrozumieć współbieżność",
                Speaker = szymon_kulec,
                About = "W świecie .NET, wspieranym obecnie przez async/await, zrozumienie programowania współbieżnego staje się pożądaną cechą każdego developera .NET. Podczas prezentacji przyjżymy się niskopoziomowym API dostarczanym przez platformę .NET, które umożliwiają tworzenie wydajnych współbieżnych struktur takich jak ConcurrentStack czy ConcurrentQueue. Skutkiem ubocznym prezentacji może być także całkowite zrozumienie architektury dzisiejszych procesorów oraz magii stojącej za volatile.",
                YoutubeUrl = ""
            };

            var session5 = new Session
            {
                Id = 4,
                Time = "19:00 - 20:00",
                Title = "Uwierzytelnianie w systemach rozproszonych",
                Speaker = marek_zając,
                About = "Rosnąca popularność usług oferowanych przez zewnętrznych dostawców w modelu SaaS, czy ostatnio popularnej architektury serverless, sprawia, że istotnym elementem integracji systemów znajdujących się w publicznej chmurze i systemów znajdujących się w siedzibie przedsiębiorstwa staje się zapewnienie bezpiecznej komunikacji pomiędzy tymi systemami. Jednym z takich przypadków może być sytuacja, gdy baza danych użytkowników znajduje się wewnątrz przedsiębiorstwa, a aplikacja na serwerach dostawcy aplikacji. Prezentacja przedstawia możliwe sposoby uwierzytelniania użytkowników w systemach rozproszonych  z uwzględnieniem technologii pojedyńczego logowania Single Sign-On.",
                YoutubeUrl = ""
            };

            var session6 = new Session
            {
                Id = 5,
                Time = "18:00 - 19:00",
                Title = "Aurelia – Create next generation JavaScript apps today",
                Speaker = dariusz_pawlukiewicz,
                About = "Trendy w świecie frontendu zmieniają się bardzo szybko – to fakt.  Czasy knockout.js i Backbone przemijają, a w ich miejsce zagościły na stałe React i AngularJs. Kto więc zostanie kolejnym trendsetterem? Wielu developerów typuje Angulara 2.0, inni przewidują utrzymanie obecnych liderów na rynku. Istnieje jednak framework, który pozostaje w cieniu Googla i Facebooka, a który ma szanse na odebranie bardzo dużego kawałka tego frontendowego tortu. Zapraszam na sesję, na której poznacie Aurelię!",
                YoutubeUrl = ""

            };

            var session7 = new Session
            {
                Id = 6,
                Time = "21:00 - 22:00",
                Title = "Jak przestałem się bać i pokochałem przetwarzanie równoległe",
                Speaker = szymon_warda,
                About = "Procesowanie wielowątkowe od dawna nie jest już tylko optymalizacją ale koniecznością. Wprowadzenie biblioteki Task Parallel Library (TPL) najlepiej znanej z .AsParallel() dodanego do LINQ może wydawać się rozwiązaniem wszystkich problemów, jednak próba użycia go przy zrównoleglaniu dużych procesów prawdopodobnie skończy się procesorem zajętym głównie przełączaniem się między wątkami. Tu na pomoc przychodzi Task Parallel Library Dataflow. Zaczniemy od idei, przez elementy z których składa się TPL Dataflow, po ważne ustawienia jak i sposoby na kontrolowanie pamięci i zużycia procesora. To poparte przykładami na żywo i własnym doświadczeniem.",
                YoutubeUrl = ""
            };

            _speakers.Add(piotr_stapp);
            _speakers.Add(pawel_lukasik);
            _speakers.Add(daniel_krzyczkowski);
            _speakers.Add(szymon_kulec);
            _speakers.Add(marek_zając);
            _speakers.Add(dariusz_pawlukiewicz);
            _speakers.Add(szymon_warda);

            _sessions.Add(session1);
            _sessions.Add(session2);
            _sessions.Add(session3);
            _sessions.Add(session4);
            _sessions.Add(session5);
            _sessions.Add(session6);
            _sessions.Add(session7);
        }

        public List<Session> Sessions { get { return _sessions; } private set { _sessions = value; } }
        public List<Speaker> Speakers { get { return _speakers; } private set { _speakers = value; } }
    }
}