namespace CharacterCatalog.Core.Collections
{
    public class Knot<T>
    {
        private T podatek; // hranimo podatke tipa T
        private Knot<T> naslednji; // referenca na naslednjega
                                    //začetek seznama je shranjen v objektu Zacetek
        private Knot<T> Zacetek;
        public Knot<T> Start  //lastnost, ki vrne začetek seznama
        {
            get { return Zacetek; }
        }
        public Knot()  // privzeti konstruktor nastavi privzete vrednosti
        {
            this.Data = default(T);
            // kazalec na naslednji element
            this.Next = null;
            Zacetek = this;
        }
        public Knot(T podatek)  //dodatni konstruktor
            : this()//dedujemo bazični konstruktor
        {
            this.Data = podatek;
        }
        public T Data  //Lastnost/property
        {
            get { return this.podatek; }
            set { this.podatek = value; }
        }
        public Knot<T> Next  //Lastnost/property
        {
            get { return this.naslednji; }
            set { this.naslednji = value; }
        }
        public void Add(T item)//Metoda za dodajanje elementa na začetek seznama
        {
            Knot<T> nov = new Knot<T>(item);
            nov.Next = Zacetek;
            Zacetek = nov;
        }
        /*metoda za dodajanje novega podatka na konec seznama: drugi parameter je klican  po referenci, saj se bo lahjo spremenil začetek seznama*/
        public void AddToEnd(T podatek)
        {
            Knot<T> kjeSmo = Zacetek;//pomožni objekt za premik po seznamu 
            while (kjeSmo.Next != null)/*dokler ne pridemo do konca seznama, oz. dokler ne najdemo podatka za brisanje*/
            {
                kjeSmo = kjeSmo.Next;//prestavimo se na naslednji objekt
            }
            //ko pridemo iz zanke kazalec tekoči zagotovo kaže na zadnji objekt
            Knot<T> nov = new Knot<T>();
            nov.Data = podatek;
            kjeSmo.Next = nov;
        }
        public int Count() //Metoda, ki vrne število elementov seznama
        {
            int stevec = 0;
            if (Zacetek != null)
            {
                Knot<T> kjeSmo = Zacetek;//začetek seznama 
                stevec = 1;
                while (kjeSmo.Next != null)
                {
                    stevec++;
                    kjeSmo = kjeSmo.Next;
                }
            }
            return stevec;
        }
        /*metoda ki v seznamu poišče podatek "podatek" in ga odstrani: prvi parameter je klican po referenci, saj se bo lahjo spremenil začetek seznama*/
        public void Remove(T podatek)
        {
            if (Zacetek.Data != null)//če seznam ni prazen
            {
                //preverimo, če je iskani podatek že na začetku seznama
                if (Zacetek.Data.Equals(podatek))
                {
                    if (Zacetek.naslednji != null)
                        Zacetek = Zacetek.Next;
                    else Zacetek = null;
                }
                else
                {
                    Knot<T> tekoči = Zacetek;//dodatni objekt za premik po seznamu 
                    while (tekoči.Next != null) /*dokler ne pridemo do konca seznama, oz. dokler ne najdemo podatka za brisanje*/
                    {
                        //ali se vsebina NASLEDNJEGA objekta ujema z našim podatkom
                        if (tekoči.Next.Data.Equals(podatek))
                        {
                            //preverimo, če ne gre slučajno za zadnji podatek v seznamu
                            if (tekoči.Next.Next != null)
                            {
                                //ker to ni zadnji objekt,prestavimo kazalec za ena naprej
                                tekoči.Next = tekoči.Next.Next;
                            }
                            else tekoči.Next = null;/*ker gre za ZADNJI objekt, nastavimo kazalec na null*/
                            break;//izhod iz zanke while
                        }
                        else tekoči = tekoči.Next;//
                    }
                }
            }
        }
    }
}
