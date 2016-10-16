﻿using System.Collections.Generic;

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
                About = "",
                Photo = "piotr_stapp.jpg"
            };

            var pawel_lukasik = new Speaker
            {
                Id = 2,
                Name = "Paweł Łukasik",
                About = "",
                Photo = "pawel_lukasik.jpeg"

            };

            var daniel_krzyczkowski = new Speaker
            {
                Id = 3,
                Name = "Daniel Krzyczkowski",
                About = "",
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
                About = "",
                Photo = "marek_zając.jpeg"
            };

            var dariusz_pawlukiewicz = new Speaker
            {
                Id = 6,
                Name = "Dariusz Pawlukiewicz",
                About = "",
                Photo = ""
            };

            var szymon_warda = new Speaker
            {
                Id = 7,
                Name = "Szymon Warda",
                About = "",
                Photo = "szymon_warda.jpg"
            };

            var session1 = new Session
            {
                Id = 1,
                Time = "15:00 - 16:00",
                Title = "Pogromcy mitów: HTTP/2 i wydajność",
                Speaker = piotr_stapp,
                About = "",
                YoutubeUrl = ""
            };

            var session2 = new Session
            {
                Id = 1,
                Time = "16:00 - 17:00",
                Title = "Hackowanie ILa",
                Speaker = pawel_lukasik,
                About = "",
                YoutubeUrl = ""
            };

            var session3 = new Session
            {
                Id = 2,
                Time = "17:00 - 18:00",
                Title = "Universal Windows 10 Platform",
                Speaker = daniel_krzyczkowski,
                About = "",
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
                About = "",
                YoutubeUrl = ""
            };

            var session6 = new Session
            {
                Id = 5,
                Time = "18:00 - 19:00",
                Title = "Aurelia – Create next generation JavaScript apps today",
                Speaker = dariusz_pawlukiewicz,
                About = "",
                YoutubeUrl = ""

            };

            var session7 = new Session
            {
                Id = 6,
                Time = "21:00 - 22:00",
                Title = "Jak przestałem się bać i pokochałem przetwarzanie równoległe",
                Speaker = szymon_warda,
                About = "",
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