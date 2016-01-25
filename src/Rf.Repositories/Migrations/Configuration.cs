namespace Rf.Repositories.Migrations
{
    using Rf.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Rf.Repositories.Contexts.FormulierDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Rf.Repositories.Contexts.FormulierDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var afdelingen = new List<Afdeling> 
            { 
                new Afdeling { Id = 1	, Afkorting = "FIN", Naam = "Financiële Dienst", Manager = "Ilse Smet" },
                new Afdeling { Id = 2	, Afkorting = "DOS", Naam = "Dossierbeheer", Manager = "Gelens Han" },
                new Afdeling { Id = 3	, Afkorting = "OPS", Naam = "Operations", Manager = "Van der Vorst Dimitri" },
                new Afdeling { Id = 4	, Afkorting = "COM", Naam = "Commerciële Dienst", Manager = "Sven Mertens" },
                new Afdeling { Id = 5	, Afkorting = "GAR", Naam = "Technische Dienst", Manager = "Geert Janssen" },
                new Afdeling { Id = 6	, Afkorting = "KWA", Naam = "Risk&Quality", Manager = "Rudi Pauwels" },
                new Afdeling { Id = 7	, Afkorting = "TPT", Naam = "Transport", Manager = "Frank Remes" },
                new Afdeling { Id = 8	, Afkorting = "ITA", Naam = "Indirect Taks", Manager = "Marc Collignon" },
                new Afdeling { Id = 9	, Afkorting = "DIR", Naam = "Directie", Manager = "Directie" },
                new Afdeling { Id = 10	, Afkorting = "RIS", Naam = "Risk Department", Manager = "Carlo Laeremans" },
                new Afdeling { Id = 11	, Afkorting = "SEC", Naam = "Secretariaat", Manager = "DR" },
                new Afdeling { Id = 12	, Afkorting = "HRM", Naam = "Human Resources", Manager = "Tine Rijsbrack" },
                new Afdeling { Id = 13	, Afkorting = "ITT", Naam = "IT-team", Manager = "Van Tongelen Johannes" },
                new Afdeling { Id = 14	, Afkorting = "DIR", Naam = "Directie (IS)", Manager = "Ilse Smet" },
                new Afdeling { Id = 15	, Afkorting = "DIR", Naam = "Directie (BH)", Manager = "Brigitte Heyndrickx" },
                new Afdeling { Id = 16	, Afkorting = "DIR", Naam = "Directie (KH)", Manager = "Kurt Heyndrickx" },
                new Afdeling { Id = 17	, Afkorting = "DIR", Naam = "Directie (MJ)", Manager = "Myriam Janssen" },
                new Afdeling { Id = 18	, Afkorting = "TIT", Naam = "TBN Inspection Team", Manager = "Sven Mertens" },
                new Afdeling { Id = 19	, Afkorting = "TPO", Naam = "TBN Polska", Manager = "Frank Remes" },
                new Afdeling { Id = 21	, Afkorting = "RAQ", Naam = "Risk & Quality", Manager = "Rudi Pauwels" },
                new Afdeling { Id = 22	, Afkorting = "QUA", Naam = "Quality", Manager = "Michèle Van Naelten" },
                new Afdeling { Id = 23	, Afkorting = "SEC", Naam = "Security", Manager = "Claeys Marnix" },
                new Afdeling { Id = 24	, Afkorting = "CSE", Naam = "CS Export", Manager = "Gelens Han" },
                new Afdeling { Id = 25	, Afkorting = "LEG", Naam = "Legal & Insurance", Manager = "Loots Johny" },
                new Afdeling { Id = 26	, Afkorting = "CSI", Naam = "CS Import", Manager = "Gelens Han" },
                new Afdeling { Id = 27	, Afkorting = "CSC", Naam = "CS Customised", Manager = "Gelens Han" },
                new Afdeling { Id = 28	, Afkorting = "PUR", Naam = "Purchase & Administration", Manager = "Michèle Van Naelten" },
                new Afdeling { Id = 29	, Afkorting = "ITI", Naam = "IT-Infrastructure", Manager = "Van Tongelen Johannes" },
                new Afdeling { Id = 30	, Afkorting = "ITD", Naam = "IT-Development", Manager = "Van Tongelen Johannes" },
                new Afdeling { Id = 31	, Afkorting = "LEV", Naam = "Leverancier", Manager = "" },
                new Afdeling { Id = 32	, Afkorting = "HES", Naam = "HESS", Manager = "Claeys Marnix" },
                new Afdeling { Id = 33	, Afkorting = "CSA", Naam = "CS Algemeen", Manager = "Gelens Han" },
                new Afdeling { Id = 35	, Afkorting = "CSS", Naam = "CS Shipping", Manager = "Gelens Han" },
                new Afdeling { Id = 36	, Afkorting = "BPA", Naam = "BPA", Manager = "Brigitte Heyndrickx" },
                new Afdeling { Id = 37	, Afkorting = "PRO", Naam = "Project Department", Manager = "Bart Kennes" }
            };                

            var bestemmingen = new List<Bestemming> { 
                new Bestemming { Id = 1, Naam = "België" },
                new Bestemming { Id = 2, Naam = "Nederland" },
                new Bestemming { Id = 3, Naam = "Krakow (Polen)" },
                new Bestemming { Id = 4, Naam = "Hainburg (Oostenrijk)" },
                new Bestemming { Id = 5, Naam = "Trier (Duitsland)" },
                new Bestemming { Id = 6, Naam = "Aqaba (Jordanië)" },
                new Bestemming { Id = 7, Naam = "Sta Cruz de Tenerife (Spanje)" },
                new Bestemming { Id = 8, Naam = "Manila (Fillipijnen)" },
                new Bestemming { Id = 9, Naam = "Krasnodar (Rusland)" },
                new Bestemming { Id = 10, Naam = "Izmir (Turkije)" },
                new Bestemming { Id = 11, Naam = "Kobe (Japan)" },
                new Bestemming { Id = 12, Naam = "Linz (Oostenrijk)" },
                new Bestemming { Id = 13, Naam = "Cherkassy (Oekraine)" },
                new Bestemming { Id = 14, Naam = "Moscow (Rusland)" },
                new Bestemming { Id = 15, Naam = "St Petersburg (Rusland)" },
                new Bestemming { Id = 16, Naam = "Tokyo (Japan)" },
                new Bestemming { Id = 17, Naam = "Cres Neva (Rusland)" },
                new Bestemming { Id = 18, Naam = "Dar Es Salaam (Tanzania)" },
                new Bestemming { Id = 19, Naam = "Otopeni (Roemenie)" },
                new Bestemming { Id = 20, Naam = "Bergen Op Zoom (Nederland)" },
                new Bestemming { Id = 21, Naam = "Kamienica (Polen)" },
                new Bestemming { Id = 22, Naam = "Kremenchuk (Oekraine)" },
                new Bestemming { Id = 23, Naam = "Jakarta (Indonesie)" },
                new Bestemming { Id = 24, Naam = "Izhora (Rusland)" },
                new Bestemming { Id = 25, Naam = "Senta (Servië)" },
                new Bestemming { Id = 26, Naam = "Guacara (Venezuela)" },
                new Bestemming { Id = 27, Naam = "Wartkowice (Polen)" },
                new Bestemming { Id = 28, Naam = "Almathy (Kazachstan)" },
                new Bestemming { Id = 29, Naam = "Luxemburg (Luxemburg)" },
                new Bestemming { Id = 30, Naam = "Klaipeda (Litouwen)" },
                new Bestemming { Id = 31, Naam = "Le Mans (Frankrijk)" },
                new Bestemming { Id = 32, Naam = "Agrinio (Griekenland)" },
                new Bestemming { Id = 33, Naam = "Nis (Servië)" },
                new Bestemming { Id = 34, Naam = "Boekarest (Roemenië)" },
                new Bestemming { Id = 35, Naam = "Eersel (Nederland)" },
                new Bestemming { Id = 36, Naam = "Lezajsk (Polen)" },
                new Bestemming { Id = 37, Naam = "Kharkiv (Oekraine)" },
                new Bestemming { Id = 38, Naam = "Belfast (Ierland)" },
                new Bestemming { Id = 39, Naam = "Nantes (Frankrijk)" },
                new Bestemming { Id = 40, Naam = "Alliances (USA)" },
                new Bestemming { Id = 41, Naam = "Eindhoven (Nederland)" },
                new Bestemming { Id = 42, Naam = "Maleisië" },
                new Bestemming { Id = 43, Naam = "Kuban (Rusland)" },
                new Bestemming { Id = 44, Naam = "Kutna Hora (Tsjechië)" },
                new Bestemming { Id = 45, Naam = "Onnens (Zwitserland)" },
                new Bestemming { Id = 46, Naam = "Buzau (Roemenië)" },
                new Bestemming { Id = 47, Naam = "Talayuela (Spanje)" },
                new Bestemming { Id = 48, Naam = "Alleghany (USA)" },
                new Bestemming { Id = 49, Naam = "Roosendaal (Nederland)" },
                new Bestemming { Id = 50, Naam = "Bucharest (Roemenië)" },
                new Bestemming { Id = 51, Naam = "Portugal" },
                new Bestemming { Id = 52, Naam = "Nigeria" },
                new Bestemming { Id = 53, Naam = "Bremen (Duitsland)" },
                new Bestemming { Id = 54, Naam = "Zuid Afrika" },
                new Bestemming { Id = 55, Naam = "Jordanië" },
                new Bestemming { Id = 56, Naam = "Zevenaar (Nederland)" },
                new Bestemming { Id = 57, Naam = "Shymkent (Kazakstan)" },
                new Bestemming { Id = 58, Naam = "Ploiesti (Roemenië)" },
                new Bestemming { Id = 59, Naam = "Snus (Zweden)" },
                new Bestemming { Id = 60, Naam = "Uzbekistan" },
                new Bestemming { Id = 61, Naam = "Petro (Rusland)" },
                new Bestemming { Id = 62, Naam = "Augustow (Polen)" },
                new Bestemming { Id = 63, Naam = "Delhi (India)" },
                new Bestemming { Id = 64, Naam = "Durban (Zuid-Afrika)" },
                new Bestemming { Id = 65, Naam = "Yelets (Rusland)" },
                new Bestemming { Id = 66, Naam = "Philsa (Turkije)" },
                new Bestemming { Id = 67, Naam = "Kruishoutem (België)" },
                new Bestemming { Id = 68, Naam = "Tabaquiera (Portugal)" },
                new Bestemming { Id = 69, Naam = "Lummen (België)" },
                new Bestemming { Id = 70, Naam = "Polen" },
                new Bestemming { Id = 71, Naam = "Alexandria (Egypte)" },
                new Bestemming { Id = 72, Naam = "Altamira (Spanje)" },
                new Bestemming { Id = 73, Naam = "Rusland" },
                new Bestemming { Id = 74, Naam = "Japan" },
                new Bestemming { Id = 75, Naam = "Turkije" },
                new Bestemming { Id = 76, Naam = "Servië" },
                new Bestemming { Id = 77, Naam = "Honduras" },
                new Bestemming { Id = 79, Naam = "NVT" },
                new Bestemming { Id = 80, Naam = "Westerlo (België)" },
                new Bestemming { Id = 81, Naam = "Indonesia" },
                new Bestemming { Id = 82, Naam = "Calais (Frankrijk)" },
                new Bestemming { Id = 83, Naam = "Nagoya (Japan)" },
                new Bestemming { Id = 84, Naam = "Torbali (Turkije)" },
                new Bestemming { Id = 85, Naam = "Port Kelang (Maleisië)" },
                new Bestemming { Id = 86, Naam = "Gebze (Turkije)" },
                new Bestemming { Id = 87, Naam = "Surabaya (Indonesië)" },
                new Bestemming { Id = 88, Naam = "Dakar (Senegal)" },
                new Bestemming { Id = 89, Naam = "Wommelgem (België)" },
                new Bestemming { Id = 90, Naam = "Tanzania" }
            };

            var betrokkenen = new List<Betrokkene> {
                new Betrokkene { Id = 1, Naam = "Betrokkene1" },
                new Betrokkene { Id = 2, Naam = "Betrokkene2" },
                new Betrokkene { Id = 3, Naam = "Betrokkene3" },
                new Betrokkene { Id = 4, Naam = "Betrokkene4" },
                new Betrokkene { Id = 5, Naam = "Betrokkene5" },
                new Betrokkene { Id = 6, Naam = "Betrokkene6" }
            };

            var cas = new List<Ca>
            {
                new Ca { Id = 1, Code = "CA01	Opleiding" },
                new Ca { Id = 2, Code = "CA02 - Bijsturing personeel" },
                new Ca { Id = 3, Code = "CA03 - Quality document opmaken" },
                new Ca { Id = 4, Code = "CA04 - Quality document reviseren" },
                new Ca { Id = 5, Code = "CA05 - Leveranciersklacht" },
                new Ca { Id = 6, Code = "CA06 - Software aanpassen" },
                new Ca { Id = 7, Code = "CA07 - Wijziging verantwoordelijkheden" },
                new Ca { Id = 8, Code = "CA08 - Opzetten controle" },
                new Ca { Id = 9, Code = "CA09 - Herstelling of correctie uitvoeren " },
                new Ca { Id = 10, Code = "CA10 - Workflow herbekijken" },
                new Ca { Id = 11, Code = "CA11 - Communicatie naar klant" },
                new Ca { Id = 12, Code = "CA12 - Opstart project" },
                new Ca { Id = 13, Code = "CA98 - Reeds eerder genomen CA" },
                new Ca { Id = 14, Code = "CA99 - Geen CA" },
                new Ca { Id = 15, Code = "CA-L-01 - (nieuwe) Afspraken vastgelegd" },
                new Ca { Id = 16, Code = "CA-L-02 - Personeel bijgestuurd" },
                new Ca { Id = 17, Code = "CA-L-03 - Algemene bijsturing" },
                new Ca { Id = 18, Code = "CA-L-04 - Herstelling uitgevoerd" },
                new Ca { Id = 19, Code = "CA-L-05 - Vervanging" },
                new Ca { Id = 20, Code = "CA-L-06 - Vervangen onder garantie" },
                new Ca { Id = 21, Code = "CA-L-98 - Reeds eerder genomen CA " },
                new Ca { Id = 22, Code = "CA-L-99 - Geen CA" }
            };

            var detailCodes = new List<DetailCode> 
            { 
                new DetailCode { Id = 1, Code = "1001 - Beschadiging aan materieel" },
                new DetailCode { Id = 2, Code = "1002 - Beschadiginig aan infrastructuur" },
                new DetailCode { Id = 3, Code = "1003 - Beschadiging aan goederen" },
                new DetailCode { Id = 4, Code = "1004 - Beschadiging paletten" },
                new DetailCode { Id = 5, Code = "1999 - Andere" },
                new DetailCode { Id = 6, Code = "2001 - Aantallen - te veel" },
                new DetailCode { Id = 7, Code = "2002 - Aantallen - te weinig" },
                new DetailCode { Id = 8, Code = "2003 - Verkeerd product" },
                new DetailCode { Id = 9, Code = "2004 - Verkeerde container/truck" },
                new DetailCode { Id = 10, Code = "2005 - Staat van de container / truck" },
                new DetailCode { Id = 11, Code = "2006 - Labels" },
                new DetailCode { Id = 12, Code = "2007 - Magazijnbeheer-locatiebeheer" },
                new DetailCode { Id = 13, Code = "2008 - Planning" },
                new DetailCode { Id = 14, Code = "2009 - Seals" },
                new DetailCode { Id = 15, Code = "2010 - Slecht geladen" },
                new DetailCode { Id = 16, Code = "2011 - Foutief ladingspatroon" },
                new DetailCode { Id = 17, Code = "2012 - Lading in overtime" },
                new DetailCode { Id = 18, Code = "2013 - Ontbreken materieel" },
                new DetailCode { Id = 19, Code = "2015 - Orde/netheid" },
                new DetailCode { Id = 20, Code = "2016 - Infestaties" },
                new DetailCode { Id = 21, Code = "2017 - Falen installatie" },
                new DetailCode { Id = 22, Code = "2018 - Traps" },
                new DetailCode { Id = 23, Code = "2019 - Te laat geleverd" },
                new DetailCode { Id = 24, Code = "2020 - Staalname" },
                new DetailCode { Id = 25, Code = "2021 - Foutieve batch/lot/merk" },
                new DetailCode { Id = 26, Code = "2022 - Foutieve grade" },
                new DetailCode { Id = 27, Code = "2023 - Verkeerde verdeling " },
                new DetailCode { Id = 28, Code = "2024 - Staat van de verpakking" },
                new DetailCode { Id = 29, Code = "2025 - Inspectie" },
                new DetailCode { Id = 30, Code = "2999 - Andere" },
                new DetailCode { Id = 31, Code = "3001 - Documenten niet meegegeven" },
                new DetailCode { Id = 32, Code = "3002 - Foutieve documenten (type)" },
                new DetailCode { Id = 33, Code = "3003 - Fout in document" },
                new DetailCode { Id = 34, Code = "3004 - Tijdstip opmaak documenten" },
                new DetailCode { Id = 35, Code = "3005 - Documenten niet gemaakt" },
                new DetailCode { Id = 36, Code = "3006 - Fouten in facturatie" },
                new DetailCode { Id = 37, Code = "3007 - Registraties - foutieve info" },
                new DetailCode { Id = 38, Code = "3008 - Registraties - ontbreken info" },
                new DetailCode { Id = 39, Code = "3009 - Registraties - te laat" },
                new DetailCode { Id = 40, Code = "3010 - Laattijdig doorgeven documenten/info" },
                new DetailCode { Id = 41, Code = "3011 - Archivering dossiers" },
                new DetailCode { Id = 42, Code = "3012 - Document / info niet doorgegeven" },
                new DetailCode { Id = 43, Code = "3013 - Communicatie" },
                new DetailCode { Id = 44, Code = "3014 - Picking in het WMS" },
                new DetailCode { Id = 45, Code = "3999 - Andere" },
                new DetailCode { Id = 46, Code = "4001 - Algemeen gedrags- en attitudeprobleem" },
                new DetailCode { Id = 47, Code = "4002 - Afwezigheid zonder tijdige melding" },
                new DetailCode { Id = 48, Code = "4003 - Niet opdagen opleiding" },
                new DetailCode { Id = 49, Code = "4004 - Veelvuldig te laat komen" },
                new DetailCode { Id = 50, Code = "4005 - Laattijdig houden evaluatiegesprek" },
                new DetailCode { Id = 51, Code = "4006 - Onnodig extra uren gepresteerd (personeel aanwervingslokaal)" },
                new DetailCode { Id = 52, Code = "4007 - Foutieve / niet uitvoering taak" },
                new DetailCode { Id = 53, Code = "4999 - Andere" },
                new DetailCode { Id = 54, Code = "5001 - Brandveiligheid" },
                new DetailCode { Id = 55, Code = "5002 - Hygiëne" },
                new DetailCode { Id = 56, Code = "5003 - Signalisatie" },
                new DetailCode { Id = 57, Code = "5004 - Veilig werken / PBM" },
                new DetailCode { Id = 58, Code = "5005 - Verkeersongeval" },
                new DetailCode { Id = 59, Code = "5006 - Arbeidsongeval" },
                new DetailCode { Id = 60, Code = "5999 - Andere " },
                new DetailCode { Id = 61, Code = "6001 - Alarm" },
                new DetailCode { Id = 62, Code = "6002 - Bewakingscamera's" },
                new DetailCode { Id = 63, Code = "6003 - Diefstal - inbraak" },
                new DetailCode { Id = 64, Code = "6004 - Omheining" },
                new DetailCode { Id = 65, Code = "6005 - Toegangscontrole" },
                new DetailCode { Id = 66, Code = "6006 - Onbewaakt parkeren" },
                new DetailCode { Id = 67, Code = "6999 - Andere" },
                new DetailCode { Id = 68, Code = "9001 - Niet terechte klacht" },
                new DetailCode { Id = 69, Code = "9002 - Dubbele registratie" },
                new DetailCode { Id = 70, Code = "9003 - Voorstel niet doorgevoerd" },
            };

            var hoofdCodes = new List<HoofdCode> 
            { 
                new HoofdCode { Id = 1, Code = "1000 - Beschadigingen" },
                new HoofdCode { Id = 2, Code = "2000 - Operationeel" },
                new HoofdCode { Id = 3, Code = "3000 - Administratie" },
                new HoofdCode { Id = 4, Code = "4000 - Personeel" },
                new HoofdCode { Id = 5, Code = "5000 - Safety" },
                new HoofdCode { Id = 6, Code = "6000 - Security" },
                new HoofdCode { Id = 7, Code = "9000 - Andere" }
            };

            var klanten = new List<Klant> 
            { 
                new Klant { Id = 1	, Naam = "Torrekens" },
                new Klant { Id = 2	, Naam = "JTI" },
                new Klant { Id = 3	, Naam = "PMP" },
                new Klant { Id = 4	, Naam = "TOUTIANA" },
                new Klant { Id = 6	, Naam = "BAT" },
                new Klant { Id = 7	, Naam = "DIMON" },
                new Klant { Id = 8	, Naam = "STUBBE" },
                new Klant { Id = 9	, Naam = "VINNIETRANS" },
                new Klant { Id = 10	, Naam = "HVL" },
                new Klant { Id = 11	, Naam = "Veys" },
                new Klant { Id = 12	, Naam = "TTS France" },
                new Klant { Id = 13	, Naam = "ASBJORNSEN" },
                new Klant { Id = 14	, Naam = "TOPTEN (cig.)" },
                new Klant { Id = 15	, Naam = "NEOS" },
                new Klant { Id = 16	, Naam = "TABAKNATIE" },
                new Klant { Id = 17	, Naam = "HEIDPARK" },
                new Klant { Id = 18	, Naam = "ULTOCO" },
                new Klant { Id = 19	, Naam = "WINTERMANS" },
                new Klant { Id = 20	, Naam = "MEERAPFEL" },
                new Klant { Id = 21	, Naam = "BICKEL" },
                new Klant { Id = 22	, Naam = "ALLIANCE ONE" },
                new Klant { Id = 23	, Naam = "ALTADIS" },
                new Klant { Id = 24	, Naam = "BIGGELAAR" },
                new Klant { Id = 25	, Naam = "VERELLEN" },
                new Klant { Id = 26	, Naam = "PREMIUM TOBACCO" },
                new Klant { Id = 27	, Naam = "FLANDRIA" },
                new Klant { Id = 28	, Naam = "PHILITAB" },
                new Klant { Id = 29	, Naam = "MISSIRIAN" },
                new Klant { Id = 30	, Naam = "MICHAILIDES" },
                new Klant { Id = 31	, Naam = "JERUSALEM CIGARETTE Cy" },
                new Klant { Id = 32	, Naam = "IMPERIAL" },
                new Klant { Id = 33	, Naam = "Bernaards Transport" },
                new Klant { Id = 34	, Naam = "HYDE PARK TRADING" },
                new Klant { Id = 35	, Naam = "KLANTEN (Algemeen)" },
                new Klant { Id = 36	, Naam = "LAG" },
                new Klant { Id = 37	, Naam = "Polisetty Somasundaram" },
                new Klant { Id = 38	, Naam = "UNIVERSAL" },
                new Klant { Id = 39	, Naam = "SCANDINAVIAN TOBACCO" },
                new Klant { Id = 40	, Naam = "Socotab Frana" },
                new Klant { Id = 41	, Naam = "Royal Distribution" },
                new Klant { Id = 42	, Naam = "Andere" },
                new Klant { Id = 43	, Naam = "PMIM" },
                new Klant { Id = 44	, Naam = "TTS Belgium" },
                new Klant { Id = 45	, Naam = "LATOB" },
                new Klant { Id = 46	, Naam = "Oz-Ege Tutun" },
                new Klant { Id = 47	, Naam = "N/A" },
                new Klant { Id = 48	, Naam = "Kukla" },
                new Klant { Id = 49	, Naam = "Ziegler" },
                new Klant { Id = 50	, Naam = "Van Doosselaere & Achten" },
                new Klant { Id = 51	, Naam = "Eolis" },
                new Klant { Id = 52	, Naam = "Godfrey Phillips India Limited" },
                new Klant { Id = 53	, Naam = "Besteldienst Herman" },
                new Klant { Id = 54	, Naam = "CMA/CGM" },
                new Klant { Id = 55	, Naam = "Medlog" },
                new Klant { Id = 56	, Naam = "FTK" },
                new Klant { Id = 57	, Naam = "MSC BELGIUM" },
                new Klant { Id = 58	, Naam = "VO AGENCIES NV" },
                new Klant { Id = 59	, Naam = "De Jaegher" }
            };                

            var locaties = new List<Locatie> {
                new Locatie { Id = 1	, Afkorting = "VDW", Naam = "Van den Wervestraat" },
                new Locatie { Id = 2	, Afkorting = "ATL", Naam = "Atlantis" },
                new Locatie { Id = 3	, Afkorting = "ARI", Naam = "Ariane" },
                new Locatie { Id = 4	, Afkorting = "APO", Naam = "Apollo" },
                new Locatie { Id = 5	, Afkorting = "ARG", Naam = "Argos" },
                new Locatie { Id = 6	, Afkorting = "POL", Naam = "Poland" },
                new Locatie { Id = 7	, Afkorting = "WES", Naam = "Westerlund" },
                new Locatie { Id = 8	, Afkorting = "ROS", Naam = "Rostock" },
                new Locatie { Id = 9	, Afkorting = "STR", Naam = "Stradok" },
                new Locatie { Id = 10	, Afkorting = "SIL", Naam = "Sils" },
                new Locatie { Id = 11	, Afkorting = "CIT", Naam = "City" },
                new Locatie { Id = 12	, Afkorting = "KRU", Naam = "Kruipin" },
                new Locatie { Id = 13	, Afkorting = "ALF", Naam = "Alfa" },
                new Locatie { Id = 14	, Afkorting = "IRI", Naam = "Iris" },
                new Locatie { Id = 15	, Afkorting = "WAY", Naam = "3-Ways" },
                new Locatie { Id = 16	, Afkorting = "MAL", Naam = "Malaga" },
                new Locatie { Id = 17	, Afkorting = "NTW", Naam = "Nietweg" },
                new Locatie { Id = 18	, Afkorting = "VIT", Naam = "Vitshoek" },
                new Locatie { Id = 19	, Afkorting = "AST", Naam = "Asterix" },
                new Locatie { Id = 20	, Afkorting = "CON", Naam = "Conquest" },
                new Locatie { Id = 21	, Afkorting = "WSL", Naam = "Waasland" },
                new Locatie { Id = 22	, Afkorting = "ODI", Naam = "Odin" },
                new Locatie { Id = 23	, Afkorting = "MAG", Naam = "373" },
                new Locatie { Id = 24	, Afkorting = "HZP", Naam = "Hazop" },
                new Locatie { Id = 25	, Afkorting = "AMO", Naam = "Amos" },
                new Locatie { Id = 26	, Afkorting = "AMO", Naam = "Amos 1-2" },
                new Locatie { Id = 27	, Afkorting = "AMO", Naam = "Amos 3-4" },
                new Locatie { Id = 28	, Afkorting = "AMO", Naam = "Amos 5-6" },
                new Locatie { Id = 29	, Afkorting = "AMO", Naam = "Amos 7-8" },
                new Locatie { Id = 30	, Afkorting = "AMO", Naam = "Amos 9-11" },
                new Locatie { Id = 31	, Afkorting = "KAA", Naam = "Kaai" },
                new Locatie { Id = 32	, Afkorting = "RIG", Naam = "Riga" },
                new Locatie { Id = 33	, Afkorting = "NVT", Naam = "NVT" }
            };               

            var oorsprongen = new List<Oorsprong>
            {
                new Oorsprong { Id = 1	, Naam = "België" },
                new Oorsprong { Id = 2	, Naam = "Nederland" },
                new Oorsprong { Id = 3	, Naam = "Duitsland" },
                new Oorsprong { Id = 4	, Naam = "Sandanski (Bulgarije)" },
                new Oorsprong { Id = 5	, Naam = "Burgas (Bulgarije)" },
                new Oorsprong { Id = 6	, Naam = "Brazilië" },
                new Oorsprong { Id = 7	, Naam = "Surabaya (Indonesie)" },
                new Oorsprong { Id = 8	, Naam = "Malawi" },
                new Oorsprong { Id = 9	, Naam = "Tanzania" },
                new Oorsprong { Id = 10	, Naam = "Belfast (Ierland)" },
                new Oorsprong { Id = 11	, Naam = "Virovitica (Kroatië)" },
                new Oorsprong { Id = 12	, Naam = "Libanon" },
                new Oorsprong { Id = 13	, Naam = "Dominicaanse Republiek" },
                new Oorsprong { Id = 14	, Naam = "Spanje" },
                new Oorsprong { Id = 15	, Naam = "United Kingdom" },
                new Oorsprong { Id = 16	, Naam = "Venezuela" },
                new Oorsprong { Id = 17	, Naam = "Polen" },
                new Oorsprong { Id = 18	, Naam = "Italië" },
                new Oorsprong { Id = 19	, Naam = "Oekranië" },
                new Oorsprong { Id = 20	, Naam = "China" },
                new Oorsprong { Id = 21	, Naam = "Indië" },
                new Oorsprong { Id = 22	, Naam = "Turkije" },
                new Oorsprong { Id = 23	, Naam = "Servië" },
                new Oorsprong { Id = 24	, Naam = "Zambia" },
                new Oorsprong { Id = 25	, Naam = "Zimbabwe" },
                new Oorsprong { Id = 26	, Naam = "Mozambique" },
                new Oorsprong { Id = 27	, Naam = "Bangladesh" },
                new Oorsprong { Id = 28	, Naam = "USA" },
                new Oorsprong { Id = 29	, Naam = "Indonesië" },
                new Oorsprong { Id = 30	, Naam = "Uganda" },
                new Oorsprong { Id = 31	, Naam = "NVT" },
                new Oorsprong { Id = 32	, Naam = "Paraguay" },
                new Oorsprong { Id = 33	, Naam = "Bulgarije" }
            };  

            var oorzaken = new List<Oorzaak> 
            { 
                new Oorzaak { Id = 1, Code = "OZ01 - Menselijke fout" },
                new Oorzaak { Id = 2, Code = "OZ02 - Gebrek aan instructie" },
                new Oorzaak { Id = 3, Code = "OZ03 - Ontbrekende of verkeerde info" },
                new Oorzaak { Id = 4, Code = "OZ04 - Onduidelijke instructie" },
                new Oorzaak { Id = 5, Code = "OZ05 - Niet/onvoldoende uitvoeren controle" },
                new Oorzaak { Id = 6, Code = "OZ06 - Uitvoering volgens bestaande afspraak" },
                new Oorzaak { Id = 7, Code = "OZ07 - Software fout / technische fout" },
                new Oorzaak { Id = 8, Code = "OZ08 - Niet/onvoldoende uitvoeren van instructie" },
                new Oorzaak { Id = 9, Code = "OZ99 - Niet bekend" },
                new Oorzaak { Id = 10, Code = "OZXX - NVT" }
            };

            var qualityProcedures = new List<QualityProcedure> 
            { 
                new QualityProcedure { Id = 1, Naam = "QP 5.1 Qualiteitsprocedure 1" },
                new QualityProcedure { Id = 2, Naam = "QP 5.2 Qualiteitsprocedure 2" },
                new QualityProcedure { Id = 3, Naam = "QP 5.2 Qualiteitsprocedure 3" },
                new QualityProcedure { Id = 4, Naam = "QP 5.2 Qualiteitsprocedure 4" },
                new QualityProcedure { Id = 5, Naam = "QP 5.2 Qualiteitsprocedure 5" }
            };

            var rps = new List<Rp> {
                new Rp { Id = 1, Naam = "RP01 - Purchase  & Administration"},
                new Rp { Id = 2, Naam = "RP02 - Sales"},
                new Rp { Id = 3, Naam = "RP03 - Customer Service"},
                new Rp { Id = 4, Naam = "RP04 - Finance"},
                new Rp { Id = 5, Naam = "RP05 - IT"},
                new Rp { Id = 6, Naam = "RP06 - Inspection Team (TIT)"},
                new Rp { Id = 7, Naam = "RP07 - HR"},
                new Rp { Id = 8, Naam = "RP08 - Quality"},
                new Rp { Id = 9, Naam = "RP09 - Maintenance / Garage"},
                new Rp { Id = 10, Naam = "RP10 - Legal & Insurance"},
                new Rp { Id = 11, Naam = "RP11 - Indirect Tax Administration"},
                new Rp { Id = 12, Naam = "RP12 - HESS"},
                new Rp { Id = 13, Naam = "RP13 - Operations"},
                new Rp { Id = 14, Naam = "RP14 - Transpor"},	
                new Rp { Id = 15, Naam = "RP15 - BPA"},
                new Rp { Id = 16, Naam = "RP16 - Project Management"},
                new Rp { Id = 17, Naam = "RP90 - TBN POLSKA"},
                new Rp { Id = 18, Naam = "RP98 - Niet bekend"},
                new Rp { Id = 19, Naam = "RP99 - LEVERANCIERS"},
                new Rp { Id = 20, Naam = "RPXX - NVT"}
            };

            var klachtSoorten = new List<SoortKlacht> 
            { 
                new SoortKlacht { Id = 1, Soort = "Soort1" },
                new SoortKlacht { Id = 2, Soort = "Soort2" },
                new SoortKlacht { Id = 3, Soort = "Soort3" },
                new SoortKlacht { Id = 4, Soort = "Soort4" },
                new SoortKlacht { Id = 5, Soort = "Soort5" }
            };

            var voertuigen = new List<Voertuig> 
            { 
                new Voertuig { Id = 1, Merk = "Toyota", Nummer = 1, NummerPlaat = "ABC123", Soort = "Baanwagen" },
                new Voertuig { Id = 2, Merk = "Scania", Nummer = 2, NummerPlaat = "ABC321", Soort = "Trekker" },
                new Voertuig { Id = 3, Merk = "Hyundai", Nummer = 3, NummerPlaat = "HEF123", Soort = "Heftruck" },
                new Voertuig { Id = 4, Merk = "Scania", Nummer = 4, NummerPlaat = "PWG123", Soort = "Personenwagen" },
                new Voertuig { Id = 5, Merk = "Hyundai", Nummer = 5, NummerPlaat = "TRE666", Soort = "Trekker" },
                new Voertuig { Id = 6, Merk = "Toyota", Nummer = 6, NummerPlaat = "HEF999", Soort = "Heftruck" },
                new Voertuig { Id = 7, Merk = "Scania", Nummer = 7, NummerPlaat = "HEF456", Soort = "Heftruck" },
                new Voertuig { Id = 8, Merk = "Hyundai", Nummer = 8, NummerPlaat = "PWG222", Soort = "Personenwagen" },
                new Voertuig { Id = 9, Merk = "Toyota", Nummer = 9, NummerPlaat = "HEF000", Soort = "Heftruck" },
                new Voertuig { Id = 10, Merk = "Hyundai", Nummer = 10, NummerPlaat = "PWG000", Soort = "Personenwagen" },
                new Voertuig { Id = 11, Merk = "Toyota", Nummer = 11, NummerPlaat = "BWG000", Soort = "Baanwagen" },
                new Voertuig { Id = 12, Merk = "Toyota", Nummer = 12, NummerPlaat = "BWG987", Soort = "Baanwagen" },
                new Voertuig { Id = 13, Merk = "Hyundai", Nummer = 13, NummerPlaat = "BWG753", Soort = "Baanwagen" },
                new Voertuig { Id = 14, Merk = "Toyota", Nummer = 1, NummerPlaat = "BWG951", Soort = "Baanwagen" },
                new Voertuig { Id = 15, Merk = "Scania", Nummer = 2, NummerPlaat = "TRE951", Soort = "Trekker" },
            };

            var personen = new List<Persoon> 
            { 
                new Persoon { Id = 1, Naam = "Naam1", Manager = true, Afdeling = afdelingen[0] }, 
                new Persoon { Id = 2, Naam = "Naam2", Manager = false, Afdeling = afdelingen[1] },
                new Persoon { Id = 3, Naam = "Naam3", Manager = false, Afdeling = afdelingen[2] }
            };

            var units = new List<Unit>
            {
                new Unit { Id = 1, Naam = "Kartons" },
                new Unit { Id = 2, Naam = "Balen" },
                new Unit { Id = 3, Naam = "Palletten" },
                new Unit { Id = 4, Naam = "Kisten" }
            };

            var processTypes = new List<ProcesType> 
            {
                new ProcesType { Id = 1, Type = "Klacht van klant (extern)" },
                new ProcesType { Id = 2, Type = "Niet-conformiteit (intern)" },
                new ProcesType { Id = 3, Type = "Onderscheiding" },
                new ProcesType { Id = 4, Type = "Voorstel" },
                new ProcesType { Id = 5, Type = "Klacht mbt leverancier" },
                new ProcesType { Id = 6, Type = "Audits" },
                new ProcesType { Id = 7, Type = "Arbeidsongevallen - verkeersongevallen" }
            };

            var rapporteringsFormulieren = new List<Formulier> 
            { 
                new Formulier
                {
                    Id = 1,
                    Omschrijving = "Test1", 
                    AkmOmschrijving ="Test Akm omschrijving 1",
                    OplossingsDatumQL = DateTime.Now,
                    OplossingsDatum = DateTime.Now,
                    AfwerkingsDatum = DateTime.Now,
                    CreatieDatum = DateTime.Now, 
                    Opsteller = personen[0],
                    Ontvanger = personen[1],
                    OntvangerQL = personen[2],
                    QualityProcedure = qualityProcedures[0],
                    HoofdCode = hoofdCodes[0],
                    Voertuig = voertuigen[0],
                    Afdeling = afdelingen[1],
                    Unit = units[0],
                    DetailCode = detailCodes[0],
                    Rp = rps[1],
                    Cas = cas.GetRange(0, 2),
                    Procestype = processTypes[0],
                    Soortklacht = klachtSoorten[0],
                    Bestemmingen = bestemmingen.GetRange(0, 2),
                    Locaties = locaties.GetRange(0, 1),
                    Betrokkenen = betrokkenen.GetRange(0, 2),
                    Oorzaken = oorzaken.GetRange(0, 1),
                    Oorsprongen = oorsprongen.GetRange(0, 1),
                    Klanten = klanten.GetRange(0, 1),
                    CommunicatieKlantOpsteller = EnumBoolean.Yes,
                    CommunicatieKlantOntvanger = EnumBoolean.Yes,
                    Gevolg = "Gevolg nummero 1",
                    OorzaakOmschrijving ="Oorzaak omschrijven test 1",
                    OorzaakAchterliggend ="achterliggende problemen 1",
                    Opmerking = "Eventuele toelichting 1",
                    Referentie = "Referentie1",
                    IsSystematischeControleVolledig = EnumBoolean.Yes,
                    TypeRf = "KlachtVanKlant",
					VoorstelAanvaard = EnumBoolean.Yes,
                    AuditTypeEnum = EnumAuditType.ExterneAudit,
                    OngevalTypeEnum = EnumOngevalType.Arbeidsongeval,
                    DossierTypeEnum = EnumDossierType.Export,
					OpnemenCapa = EnumBoolean.Yes,
                    ClaimNummer = "AB1",
                    Kost = 10,
                    BeveiligingsIncident = EnumBoolean.No,
                    AantalUnits = 1,
                    SystematischeControleOpsteller = EnumBoolean.Yes,
                    SystematischeControleOntvanger = EnumBoolean.Yes,
                    NieuweControle = EnumBoolean.Yes,
                    IsQualityDocumentBeschreven = EnumBoolean.Yes,
                    IsQualityDocumentVolledig = EnumBoolean.Yes,
                    IsNieuwQualityDocumentNodig = EnumBoolean.Yes,
                    DoorrekenenKost = EnumBoolean.Yes,
                    KlachtGeuitDoor = "TestNaam1"
                }
            };

            foreach (Afdeling item in afdelingen)
            {
                context.Afdelingen.AddOrUpdate(dest => dest.Naam, item);
            }
            foreach (Bestemming item in bestemmingen)
            {
                context.Bestemmingen.AddOrUpdate(dest => dest.Naam, item);
            }
            foreach (DetailCode item in detailCodes)
            {
                context.DetailCodes.AddOrUpdate(dest => dest.Code, item);
            } 
            foreach (HoofdCode item in hoofdCodes)
            {
                context.HoofdCodes.AddOrUpdate(dest => dest.Code, item);
            } 
            foreach (Klant item in klanten)
            {
                context.Klanten.AddOrUpdate(dest => dest.Naam, item);
            }
            foreach (Locatie item in locaties)
            {
                context.Locaties.AddOrUpdate(dest => dest.Naam, item);
            }
            foreach (Oorsprong item in oorsprongen)
            {
                context.Oorsprongen.AddOrUpdate(dest => dest.Naam, item);
            }
            foreach (Oorzaak item in oorzaken)
            {
                context.Oorzaken.AddOrUpdate(dest => dest.Code, item);
            }
            foreach (QualityProcedure item in qualityProcedures)
            {
                context.QualityProcedures.AddOrUpdate(dest => dest.Naam, item);
            }
            foreach (Rp item in rps)
            {
                context.Rps.AddOrUpdate(dest => dest.Naam, item);
            }
            foreach (SoortKlacht item in klachtSoorten)
            {
                context.KlachtSoorten.AddOrUpdate(dest => dest.Soort, item);
            }
            foreach (Voertuig item in voertuigen)
            {
                context.Voertuigen.AddOrUpdate(dest => dest.NummerPlaat, item);
            }
            foreach (Persoon item in personen)
            {
                context.Personen.AddOrUpdate(dest => dest.Naam, item);
            }
            foreach (Betrokkene item in betrokkenen)
            {
                context.Betrokkenen.AddOrUpdate(dest => dest.Naam, item);
            }
            foreach (Unit item in units)
            {
                context.Units.AddOrUpdate(dest => dest.Naam, item);
            }

            context.Formulieren.AddOrUpdate(a => a.Omschrijving, rapporteringsFormulieren[0]);
        }
    }
}