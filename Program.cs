

Console.WriteLine("Quanto você deseja sacar? ");
string saqueStr = Console.ReadLine();
float saque;

if (float.TryParse(saqueStr, out saque))
{
    float saldo = 800.0f;
    float saldo_final = saldo - saque;
    Console.WriteLine("Seu saldo final é: " + saldo_final);
}
else
{
    Console.WriteLine("Entrada inválida. Certifique-se de digitar um número válido.");
}
