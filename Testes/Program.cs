Console.WriteLine($"Vamos jogar um jogo de aventura por texto\nUse sim ou nao para fazer as escolhas iniciais");

string respostainput = Console.ReadLine();
string lugar1 = "piraquara";
string lugar2 = "colombo";
string lugar3 = "batel";


if (respostainput == "sim" )
{
    Console.WriteLine($"Tu irá começar no estado do Paraná,\nAgora escolha o bairro de inicio:");
    Console.WriteLine($"\nLocais : Piraquara,Colombo,Batel");

    string escolhabairro = Console.ReadLine();

    if (escolhabairro == "piraquara")
    {
        Console.WriteLine($"A sua jornada começa em uma estrada de terra.");
    }
    else if (escolhabairro == "colombo")
    {
        Console.WriteLine("A sua jornada começa em uma rua calma");
    }
    else if(escolhabairro == "batel")
    {
        Console.WriteLine($"A sua jornada começa em uma cobertura de um ap de luxo");
    }
    
}
else if (respostainput != "nao")
{
    Console.WriteLine($"Então vá comer um rollmops!:");
    
}

Console.WriteLine($":D");















