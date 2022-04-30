// See https://aka.ms/new-console-template for more 
for(var i =0; i<=2; i++){
Console.WriteLine("Infome sue nome");
var nome = Console.ReadLine();
Console.WriteLine("Infome sua primeira nota");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Infome sua segunda nota nota");
int n2 = Convert.ToInt32(Console.ReadLine());
float media;
media = (n1 + n2) / 2f;
if (media<5)
{ Console.WriteLine(" {0}, ficou com a media {1} e foi reprovado", nome, media);
     Console.WriteLine($"  {nome}, ficou com a media ${media} e fio reprovado");
}
else
{
    Console.WriteLine("Seu Nome é " + nome + " Sua idade é " + media);
}
}



Console.ReadKey();
