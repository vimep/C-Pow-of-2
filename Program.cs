
int numeri;

Console.Title = "Generatore di potenze";
Console.Write("Quanti numeri vuoi alla potenza di 2: ");
numeri = Convert.ToInt32( Console.ReadLine() );


if (numeri == 0) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("il numero deve essere superiore a 0!");
}
else {
    for (int i = 1; i <= numeri; i++) {
    double risultato = Math.Pow(2,i);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Il risultato della potenza di due alla: " + numeri + " è " + risultato);
}
}

Console.ReadKey();