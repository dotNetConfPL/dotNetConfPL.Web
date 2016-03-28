using System.Collections.Generic;

namespace dotnetconfpl.Areas._2015.Model
{
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

            var stapp_janiszewski = new Speaker
            {
                Id = 2,
                Name = "Piotr Stapp i Mateusz Janiszewski",
                About = "Piotr jest programistą, inżynierem, rzemieślnikiem, projektantem i rowerzystą. Korzysta z każdej technologii, która prowadzi do celu. Wierzy w ludzi a nie w papiery. Wyznaje DevOps i automatyzacje wszelaką. Na co dzień Ekspert IT w mBanku. Mateusz jest entuzjasta wirtualizacji i infrastruktury. Na co dzień Bus & Sys Integration Analyst w Accenture.",
                Photo = "piotr_stapp.jpg"

            };

            var slawomir_sobotka = new Speaker
            {
                Id = 3,
                Name = "Sławomir Sobótka",
                About = "Trener i konsultant w firmie Bottega IT Solutions, specjalizuje się w technologiach Java EE. W codziennej pracy integruję Domain Driven Design, wzorce, style architektoniczne, zwinne procesy wytwórcze i zdrowy rozsądek. Stosuje nadrzędną zasadę: rozpoznać klasę problemu z jaką mamy do czynienia i dobrać do niej odpowiednią klasę narzędzia. Hobbystycznie interesuje się psychologią pozytywną i kognitywistyką. Lubi myśleć o sobie jako entuzjaście Software Craftsmanship.",
                Photo = "slawomir_sobotka.jpg"
            };

            var marcin_malinowski = new Speaker
            {
                Id = 4,
                Name = "Marcin Malinowski",
                About = "Tata^2, mąż humanistki, mól książkowy, uparciuch, programista, konferencjoholik. Don Kichot walczący z entropią. Kocha sprzeczności i humor. Wierzy w przypadek. Piwny filozof. W nielicznych wolnych chwilach harata w gałę (na bramce). Basic, Turbo Pascal / C, Assembler, Clipper, MS Access, Visual Basic, Java - XML :), C++, C#, JavaScript, F#... i ze wszystkiego miałem frajdę, ale nie za wszystkim tęsknię. Absolwent informatyki i matematyki na UW.Tech lead w firmie Piątka.",
                Photo = "marcin_malinowski.jpg"
            };

            var jakub_gutkowski = new Speaker
            {
                Id = 5,
                Name = "Jakub Gutkowski",
                About = "Tata, mąż, blogger, pasjonat i programista. Uwielbia bawić się nowościami, poznawać nowe języki i biblioteki, chodzić na konferencje, poznawać nowych ludzi, pomagać innym. Uwielbia testować nowe języki, biblioteki, narzędzia w poszukiwaniu perfekcyjnego narzędzia do danego zadania z nadzieją, że kiedyś znajdzie coś co będzie u niego w końcu działało. Od wielu lat, Microsoft MVP z dziedzin C# jak i SharePoint. Wierzy, że to co robi zmienia świat i pomaga innym.",
                Photo = "jakub_gutkowski.png"
            };

            var waldemar_mekal = new Speaker
            {
                Id = 6,
                Name = "Waldemar Mękal",
                About = "Skromny team leader / developer w firmie PGS Software. Wieloletnie doświadczenie w.NET z ciekawymi przygodami w PHP i JAVA. Zwolennik prostoty we wszelkich jej przejawach. Ostatnio bardziej aktywny prelegencko.",
                Photo = "waldemar_mekal.jpeg"
            };

            var arkadiusz_benedykt = new Speaker
            {
                Id = 7,
                Name = "Arkadiusz Benedykt",
                About = "Developer z zamiłowania. Pierwszy kontakt z komputerami miał mając raptem kilka lat, na polskim komputerze Odra. To wystarczyło, aby złapał bakcyla. Pierwsze aplikacje pisał mając 15 lat. Od ponad 10 lat aktywny zawodowo w pełnym wymiarze. Tworzył aplikacje desktopowe, serwerowe, usługi, a ostatnio skupia się na aplikacjach webowych. Od lat związany z technologiami Microsoft. Czasem zagląda również do innych ekosystemów. Poza działalnością zawodową, realizuje się pracując jako trener oraz prowadzi zajęcia na uczelni wyższej z zakresu inżynierii oprogramowania. Prowadzi również bloga pod adresem <a href=\"http://www.benedykt.net\">www.benedykt.net</a>",
                Photo = "arkadiusz_benedykt.jpg"
            };


            var session1 = new Session
            {
                Id = 1,
                Time = "16:00 - 17:00",
                Title = "Testy jednostkowe w praktyce, vol 3: testy konwencji",
                Speaker = maciej_aniserowicz,
                About = "Po dwóch prezentacjach o testach na dotNetConfPL (<a href=\"https://youtu.be/gQaShMN_tN8\">Testy jednostkowe w .NET</a>, <a href=\"https://youtu.be/zfyUQKktc4w\">Testy jednostkowe w praktyce, vol 2</a>) czas na coś z zupełnie innej beczki: prelekcję o testach! Tym razem skupimy się na zupełnie innym przypadku, w którym testy automatyczne mogą okazać się niezwykle pomocne. Będzie o tzw \"convention tests\". Co mają wspólnego testy z kompilatorem ? Jak upewnić się, że nawet nowe osoby w zespole programują \"tak jak trzeba\"? Albo że bug, na który natknęliśmy się dzisiaj, nie powtórzy się nigdy więcej w skali całego systemu? To tylko kilka pytań, na które odpowiem podczas swojego wystąpienia. Zapraszam!",
                YoutubeUrl = "https://www.youtube.com/embed/zvrxNubED_E"
            };

            var session2 = new Session
            {
                Id = 2,
                Time = "17:00 - 18:00",
                Title = "Vagrant with Windows czyli włóczęga z oknami",
                Speaker = stapp_janiszewski,
                About = "Tworzenie reprodukowalnych środowisk na Windows zawsze było dużą bolączką. Ale świat poszedł do przodu i narzędzia typowo Linuxowe stały się dostępne na Windows. W naszej sesji pokażemy od zera do bohatera jak postawić własne środowisko testowe dla programisty .NET.",
                YoutubeUrl = "https://www.youtube.com/embed/EHFpMHhUFXQ"
            };

            var session3 = new Session
            {
                Id = 3,
                Time = "20:00 - 21:00",
                Title = "Co było pierwsze: kod czy architektura?",
                Speaker = slawomir_sobotka,
                About = "Kim jest architekt? Czasem dostajesz taki tytuł zamiast podwyżki. Czasem jest to powód do dumy a czasem nie. Zastanowimy się od innej strony: czasem bywasz architektem - co powinieneś wiedzieć i umieć? Podejdziemy również coachingowo: co ma w głowie architekt i jak rozumuje i podejmuje decyzje? Problem jest taki, że są w naszej branży trzy słowa, których nikt nie rozumie: architektura, moduł i komponent.Pokażę jakie są poziomy architektury, jak je wizualizować, po co i jakie wprowadzamy ograniczenia na każdym z poziomów. Zastanowimy się też kiedy da się zakładać z góry architekturą a kiedy może ona wyłaniać się z niskopoziomowych decyzji w kodzie.Aby móc wyłaniać architekturę poznamy nieco wzorców architektury aplikacyjnej i systemowej oraz kodowania w notatniku. Tak przy okazji: czy REST ma zawsze sens?",
                YoutubeUrl = "https://www.youtube.com/embed/JvzRYDpclJ8"
            };

            var session4 = new Session
            {
                Id = 4,
                Time = "19:00 - 20:00",
                Title = "Funkcyjne zabawki w obiektowej piaskownicy",
                Speaker = marcin_malinowski,
                About = "Wiedza o tym, skąd autorzy języka C# czerpali inspiracje, jakie były ich intencje i jakie są ich długofalowe plany, nie jest powszechna. Tymczasem uważam, że bez niej nie można w pełni wykorzystać potencjału zawartego w tym języku. Silne przenikanie paradygmatu funkcyjnego do obiektowego, w pierwotnych założeniach języka, nie będzie zaskoczeniem, gdy uświadomimy sobie, że ci sami autorzy stworzyli również język F#. Ten młodszy i biedniejszy kuzyn poczyna sobie całkiem nieźle i stał się główną inspiracją dla najnowszego wcielenia swojego starszego krewnego. Niedawne otwarcie przez Microsoft platformy .NET i upublicznienie zapisów spotkań komitetu projektowego, daje nam niemożliwy wcześniej wgląd w proces powstawania przyszłych wersji tego języka. Jedno wiemy już na pewno: funkcyjnych zabawek będzie jeszcze więcej!",
                YoutubeUrl = "https://www.youtube.com/embed/zml5Q2kU0u0"
            };

            var session5 = new Session
            {
                Id = 5,
                Time = "18:00 - 19:00",
                Title = "Double Loop TDD z MVC 6 w praktyce",
                Speaker = waldemar_mekal,
                About = "W trakcie wystąpienia pokażę jak praktycznie stosować Double Loop TDD w aplikacjach pisanych w oparciu o MVC 6 i EF 7. Zaimplementuję nowy feature zaczynając od stworzenia testu akceptacyjnego UI. Następnie będe tworzył kolejne testy jednostkowe i kod aplikacji, tak by uzyskać działającą funkcjonalność.",
                YoutubeUrl = "https://www.youtube.com/embed/c9FdwL1_TBE"

            };

            var session6 = new Session
            {
                Id = 6,
                Time = "21:00 - 22:00",
                Title = "Internet of Things gdzie zacząć",
                Speaker = arkadiusz_benedykt,
                About = "Internet of Things to wielki buzz word ostatnich miesięcy. Jeśli coś nie jest Internet of Things to nie ma sensu tego kupować. Na początek pokażę w telegraficznym skrócie co to jest Internet of Things i dlaczego warto się tym zainteresować a potem pokażę od czego zacząć aby stworzyć swój pierwszy rewolucyjny produkt. Czyli zaglądniemy w podstawy - podstawy elektroniki oraz zastanowimy się w co trzeba zainwestować i jak później poskładać pierwsze działające urządzenie.",
                YoutubeUrl = "https://www.youtube.com/embed/9wqnnsCBl1U"
            };

            var session7 = new Session
            {
                Id = 7,
                Time = "15:00 - 16:00",
                Title = "ASP.NET vNext - Na co zwrócić uwagę",
                Speaker = jakub_gutkowski,
                About = "ASP.NET vNext mimo że jeszcze w beta, dostarcza już szereg ciekawych rozwiązań które nie tylko ułatwią nam programistom tworzenie oprogramowania, ale także pozwolą na większą swobodę pracy, nie ograniczając nas do jedynego słusznego systemu operacyjnego. Większa część nowości przelała się już po sieci, jednak wciąż są rejony vNext o których dużo niema, a są na tyle interesująe i praktyczne, że aż dziw iż musieliśmy tyle na nie czekać :) Jakie to elementy? Zapraszam na sesję na której pominiemy dnx'y, a skoncentrujemy się na tym co dają nam już dostępne biblioteki i paczki NuGet.",
                YoutubeUrl = "https://www.youtube.com/embed/VweIDqCs_tI"
            };

            _speakers.Add(maciej_aniserowicz);
            _speakers.Add(arkadiusz_benedykt);
            _speakers.Add(jakub_gutkowski);
            _speakers.Add(marcin_malinowski);
            _speakers.Add(waldemar_mekal);
            _speakers.Add(slawomir_sobotka);
            _speakers.Add(stapp_janiszewski);

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