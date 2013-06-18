using System;
using Raven.Client.Embedded;
using dotnetconfpl.DAL;

namespace dotnetconfpl.App_Start
{
    public static class RavenDb
    {
        public static EmbeddableDocumentStore DocumentStore { get; private set; }

        public static void StartRavenDb()
        {
            DocumentStore = new EmbeddableDocumentStore
                {
                    DataDirectory = "~/App_Data",
                    UseEmbeddedHttpServer = false
                };

            DocumentStore.Initialize();
        }
    }
}