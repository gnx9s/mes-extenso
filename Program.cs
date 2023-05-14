Console.WriteLine("--- MÊS POR EXTENSO ---");

Console.Write("Escreva um número compatível com algum mês do ano... ");
int mesNumero = Convert.ToInt32(Console.ReadLine());
string mensagem;

if (mesNumero <= 12 && mesNumero > 0)
{
    if (mesNumero == 1)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Janeiro!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 2)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Fevereiro!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 3)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Março!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 4)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Abril!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 5)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Maio!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 6)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Junho!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 7)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Julho!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 8)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Agosto!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 9)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Setembro!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 10)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Outubro!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 11)
    {
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Novembro!";
        corzinha1();
        escrever();
    }
    
    else if (mesNumero == 12)
    {    
        mensagem = $"O número digitado ({mesNumero}) confere com o mês de Dezembro!";
        corzinha1();
        escrever();
    }
}
else 
{
    mensagem = "O valor digitado não corresponde a nenhum mês! Digite um valor válido.";
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Red;
    escrever();
}

Console.ResetColor();

void escrever()
{
    Console.WriteLine(mensagem);
    Console.WriteLine();
}

void corzinha1()
{
    Console.ForegroundColor = ConsoleColor.Green;
}