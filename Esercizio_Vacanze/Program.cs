using System;

namespace Esercizio_Vacanze
{
    class Program
    {
        static void Main(string[] args)
        {
            //la variabile può contenere valori compresi fra -2147483648(2^32-1) e 2147483647(2^32): si tratta esattamente di 2^32 = 4294967296 valori suddivisi fra negativi e positivi. quindi l'output alla riga 10 è il valore massimo ottenibile, mentre quello alla riga 11 è il valore minimo, cioè  2^31, quindi l'ultimo bit è occupato dal segno meno.
            int a = int.MaxValue;
            Console.WriteLine(a);
            if (a == 2147483647)
            {
                Console.WriteLine(a + 1);//l'output per essere giusto deve essere uguale a 2147483647, quindi in tutti i casi in cui il risultato è diverso da 2147483647, l'istruzione della riga 14 non viene effettuata
            }
                int b = -128;
                int c = -b;
                Console.WriteLine(Convert.ToString(b, 2));//conversione in binario
                Console.WriteLine(Convert.ToString(c, 2));//conversione in binario
                int value = 31;
                int somma = value;
                value = ~value + 1;//NOT
                                   //value=value+1;
                somma = somma + value;
                Console.WriteLine($"{value} e {somma}");//il valore value è uguale all'ooposto del valore inserito dall'utente, mentre la somma è uguale alla somma tra il numero inserito ed il suo opposto
                long number = 55555;
                Console.WriteLine(Convert.ToString(number, 2));//variabile number trasformata in numero binario
                short number1 = (short)number;//la variabile number viene trasformata da tipo long a tipo short e prende il nome di number1
                Console.WriteLine(number1);//il numero è sbagliato perche quando viene stampato il valore 55555, bisogna ricordarsi che è stato tramutato in short: ma il tipo short non ha la capienza necessaria per contenere quel numero perche i suoi valori possibili vanno da -32768 a 32767
            // il programma va in una situazione di overflow: cioè che la memoria non ha abbastanza capacita per contenere un valore. questo perche 55555-32768 e poi bisogna fare = 22.788‬ - 32768 = 9981 e l'ultimo risultato va convertito in negativo
        }
    }
}
