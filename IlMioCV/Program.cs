using IlMioCV.Models;  // Importiamo il namespace con le classi

class Program
{
    static void Main()
    {
        // Creazione dell'oggetto CV
        CV mioCV = new CV();

        // Inserimento delle informazioni personali
        mioCV.InfoPersonali = new InformazioniPersonali
        {
            Nome = "Mario",
            Cognome = "Rossi",
            Telefono = "333-1234567",
            Email = "mario.rossi@email.com"
        };

        // Inserimento degli studi effettuati
        mioCV.StudiEffettuati.Add(new Studi
        {
            Qualifica = "Laurea in Informatica",
            Istituto = "Università di Roma",
            Tipo = "Universitaria",
            Dal = 2015,
            Al = 2019
        });

        mioCV.StudiEffettuati.Add(new Studi
        {
            Qualifica = "Master in Cybersecurity",
            Istituto = "Politecnico di Milano",
            Tipo = "Post-laurea",
            Dal = 2020,
            Al = 2021
        });

        // Inserimento delle esperienze lavorative
        mioCV.Impieghi.Add(new Impiego
        {
            EsperienzaLavorativa = new Esperienza
            {
                Azienda = "TechSoft S.p.A.",
                JobTitle = "Software Developer",
                Dal = 2019,
                Al = 2022,
                Descrizione = "Sviluppo software per soluzioni aziendali",
                Compiti = "Analisi, sviluppo e manutenzione di applicazioni"
            }
        });

        mioCV.Impieghi.Add(new Impiego
        {
            EsperienzaLavorativa = new Esperienza
            {
                Azienda = "CyberSecure Ltd.",
                JobTitle = "Cybersecurity Analyst",
                Dal = 2022,
                Al = 2024,
                Descrizione = "Analisi e protezione di reti informatiche",
                Compiti = "Monitoraggio della sicurezza, audit e implementazione di soluzioni"
            }
        });

        // Stampa il CV su schermo
        StampaDettagliCVSuSchermo(mioCV);
    }

    // Metodo per stampare il CV
    static void StampaDettagliCVSuSchermo(CV cv)
    {
        Console.WriteLine("====================================");
        Console.WriteLine("             CURRICULUM VITAE       ");
        Console.WriteLine("====================================\n");

        // Informazioni personali
        Console.WriteLine("📌 INFORMAZIONI PERSONALI");
        Console.WriteLine($"Nome: {cv.InfoPersonali.Nome}");
        Console.WriteLine($"Cognome: {cv.InfoPersonali.Cognome}");
        Console.WriteLine($"Telefono: {cv.InfoPersonali.Telefono}");
        Console.WriteLine($"Email: {cv.InfoPersonali.Email}\n");

        // Studi effettuati
        Console.WriteLine("📚 STUDI EFFETTUATI");
        foreach (var studi in cv.StudiEffettuati)
        {
            Console.WriteLine($"- {studi.Qualifica} presso {studi.Istituto} ({studi.Tipo}) - {studi.Dal} / {studi.Al}");
        }
        Console.WriteLine();

        // Esperienze lavorative
        Console.WriteLine("💼 ESPERIENZE LAVORATIVE");
        foreach (var impiego in cv.Impieghi)
        {
            var esperienza = impiego.EsperienzaLavorativa;
            Console.WriteLine($"- {esperienza.JobTitle} presso {esperienza.Azienda} ({esperienza.Dal} - {esperienza.Al})");
            Console.WriteLine($"  Descrizione: {esperienza.Descrizione}");
            Console.WriteLine($"  Compiti: {esperienza.Compiti}\n");
        }

        Console.WriteLine("====================================");
        Console.WriteLine("       FINE CURRICULUM VITAE        ");
        Console.WriteLine("====================================");
    }
}