using System;
using static System.Guid;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WizaKonsulPLACOWKA.Models
{
    public class Sprawa
    {
        //gdzie sie w ASP.NET zapisuje enumy? (Decyzja)
        //skoro mamy walidacje danych w modelu to czy tu musimy powtarzac?
        //na razie daję gettery i settery dla wszystkiego co jest, pozniej sie zastanowimy czy zmieniac
        //czy w implementacji nazwy wlasciwosci muszą być takie same jak w naszym cudownym Modelu Informacyjnym? 
        //Bo mamy tam małe litery a C# chyba zaleca konwencję z dużymi jako nazwą Wlasciwosci
        public Guid Id { get; set; } = NewGuid(); //ok, to może być problematyczne bo to nadaje cetrala(?) 
        public String Tresc { get; set; }
        public String ImieKlienta { get; set; } 
        public String NazwiskoKlienta { get; set; }
        public String AdresKlienta { get; set; }
        public String NrDokumentuKlienta { get; set; }
        public String TypDokumentuKlienta { get; set; } //na razie String - TODO link ze slownikiem?
        public String ZdjecieKlienta { get; set; } //rozumiem że link do zdj - czy jest jakis typ na linki/regular expression na linki?
        public String Decyzja { get; set; } = "Do uzupelnienia"; //Tak to było czy null? Polskie znaki?
        public bool czyOtwarta
        {
            get
            {
                return Decyzja == "Do uzupelnienia";
            }
            
        }
        public DateTime DataPrzeslania { get; } = DateTime.Now; // tu uwaga bo to pobiera terazniejszy czas, 
                                                                //czyli obiekt musi być utworzony dokładnie gdy wcisniemy przycisk!
        
            
        //konstruktor niepotrzebny
        //referencje na twórcę i inne potem
        //metody z klasy object, może sie przydadzą
        public override string ToString()
        {
            return $"Sprawa:\n ID {Id} \nNazwisko klienta {NazwiskoKlienta}\nTresc sprawy {Tresc.Substring(0, 50)}...\nDecyzja {Decyzja}\n";
            //co ty na to?
        }
        



    }
}
