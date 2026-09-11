namespace Ovningar_konvert_niva3_sista_11_09_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tal = { 5, 10, 15, 20 };
            int summa = 0;

            // *Bugg 1, i <= tal.Length
            for (int i = 0; i < tal.Length; i++)
                // *Bugg 2, saknade { } i for loopen
            {
                summa += tal[i];
            }
            double medel = (double)summa / tal.Length;
            Console.WriteLine($"Medel: {medel}");
        }
    }
}

// *BUGG 1
// När i blir större än 3 så kan summa += tal[i] inte hitta index 4 eller större i arrayen,
// eftersom arrayen tal[] bara har values i 0,1,2,3 positionerna.
// Vi löser detta genom att ändra i <= tal.Length till i < tal.Length.
// Så vi avbryter loopen innan vi går förbi längden på arrayen

// *BUGG 2
// For loopen saknade {}
// Men det påverkade inte körningen
// Så jag är osäker på om det var en bugg eller inte

// *BUGG 3
// Hittar ingenting mer
// Koden kan köras utan problem nu