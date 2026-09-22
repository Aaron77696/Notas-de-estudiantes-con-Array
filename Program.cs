int[] notas = { 18, 20, 15, 12};

Console.WriteLine("Notas del estudiante: ");
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Nota {i+1}: {notas[i]}");
}