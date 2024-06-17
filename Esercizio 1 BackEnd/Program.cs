using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1_BackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creazione istanze e stampa a schermo
            Atleta atleta = new Atleta("Usain", "Bolt", "Corsa");
            atleta.StampaDettagli();

            Dipendendente dipendente = new Dipendendente("Mario", "Rossi", "IT", "Sviluppatore");
            dipendente.StampaDettagli();

            Animale animale = new Animale("Leone", "Panthera leo");
            animale.StampaDettagli();

            Veicolo veicolo = new Veicolo("Ferrari", "488", 2020);
            veicolo.StampaDettagli();

            Console.ReadLine();
        }
    }

    class Atleta
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Disciplina { get; set; }

        public Atleta(string nome, string cognome, string disciplina)
        {
            Nome = nome;
            Cognome = cognome;
            Disciplina = disciplina;
        }

        public void StampaDettagli()
        {
            Console.WriteLine($"Atleta: {Nome} {Cognome}, Disciplina: {Disciplina}");
        }
    }

    class Dipendendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Dipartimento { get; set; }
        public string Posizione { get; set; }

        public Dipendendente(string nome, string cognome, string dipartimento, string posizione)
        {
            Nome = nome;
            Cognome = cognome;
            Dipartimento = dipartimento;
            Posizione = posizione;
        }

        public void StampaDettagli()
        {
            Console.WriteLine($"Dipendente: {Nome} {Cognome}, Dipartimento: {Dipartimento}, Posizione: {Posizione}");
        }
    }

    class Animale
    {
        public string Specie { get; set; }
        public string NomeScientifico { get; set; }

        public Animale(string specie, string nomeScientifico)
        {
            Specie = specie;
            NomeScientifico = nomeScientifico;
        }

        public void StampaDettagli()
        {
            Console.WriteLine($"Animale: {Specie}, Nome Scientifico: {NomeScientifico}");
        }
    }

    class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }

        public Veicolo(string marca, string modello, int anno)
        {
            Marca = marca;
            Modello = modello;
            Anno = anno;
        }

        public void StampaDettagli()
        {
            Console.WriteLine($"Veicolo: {Marca} {Modello}, Anno: {Anno}");
        }
    }
}
