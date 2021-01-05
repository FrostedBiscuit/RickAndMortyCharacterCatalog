using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCatalog.Core.Collections
{
    public class GenericCollection<T> : ICollection<T>
    {
        private T[] elementi;  //tabelarično polje
        private int velikost;   //polje hrani trenutno število podatkov v tabeli    
        public GenericCollection()
        { elementi = new T[0]; velikost = 0; }
        public GenericCollection(int n = 0)  //konstruktor
        { elementi = new T[n]; velikost = n; }//začetna dimenzija tabele/zbirke  
        public T this[int indeks]   //indeksiranje 
        {
            get { return elementi[indeks]; } //dostop do posameznih polj
            set { elementi[indeks] = value; }  //prirejanje vrednostim poljem
        }
        //napišimo property, s katerim pridobimo atribut velikost
        public int Velikost
        {
            get { return velikost; }
        }

        public int Count => velikost;

        public bool IsReadOnly => false;
            
        //še get metoda za prodobivanje polja velikost
        public int VrneVelikost()
        {
            return velikost;
        }

        public void OdstraniVse()
        {
            elementi = new T[0];
            velikost = 0;
        }
        public void Add(T podatek)  //metoda za dodajanje novega elementa 
        {
            Array.Resize(ref elementi, elementi.Length + 1);
            elementi[velikost] = podatek;  //podatek zapišemo v prvo prosto celico
            velikost = velikost + 1; //število zasedenih celic
        }
        //generična metoda za brisanje celice z določenim indeksom
        public bool RemoveAt(int index)
        {
            if (velikost == 0)
            {
                Console.WriteLine("Zbirka je prazna, brisanje NI možno!");

                return false;
            }
            //celico brišemo le, če je njen indeks manjši od dimenzije zbirke  
            // if (indeksCelice < elementi.Length && indeksCelice >= 0)
            else if (index < elementi.Length)
            {
                T[] zacasna = new T[elementi.Length - 1];
                int j = 0;
                for (int i = 0; i < elementi.Length; i++)
                {
                    if (i != index)
                    {
                        zacasna[j] = elementi[i];
                        j++;
                    }
                }
                elementi = zacasna;
                velikost = velikost - 1;//zmanjšamo velikost zbirke
            }
            else Console.WriteLine("Brisanje NI možno, ker indeks št "+index+" NE obstaja!");
            return true;
        }

        //generična metoda za izpis poljubne zbirke
        public void IzpisZbirke()
        {
            if (velikost == 0)
                Console.WriteLine("Zbirka je prazna!");
            else
            {
                Console.WriteLine("Izpis ZBIRKE: ");
                for (int i = 0; i < elementi.Length; i++)
                    Console.WriteLine(elementi[i].ToString() + " ");
                Console.WriteLine();
            }
        }

        public void Clear()
        {
            velikost = 0;
            elementi = new T[0];
        }

        public bool Contains(T item)
        {
            return elementi.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            array = elementi.Skip(arrayIndex).ToArray();
        }

        public bool Remove(T item)
        {
            var elementsList = elementi.ToList();
            var result = elementsList.Remove(item);

            elementi = elementsList.ToArray();

            if (result)
                velikost = Math.Max(0, velikost--);

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return elementi.ToList().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elementi.GetEnumerator();
        }
    }
}
