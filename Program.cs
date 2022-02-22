using System; 
using System.Globalization; 

namespace ConsoleApp1; 

class Tarefinha{ 

	static void Main(string[] args){
		string produto1 = "Computador";
		string produto2 = "Mesa de Escritório";

		byte idade = 30; 
		int codigo = 5290;
		char genero = 'M';

		double preco1 = 2100.0;
		double preco2 = 650.00; 
		double medida = 53.2345678;

		System.Console.WriteLine("Produtos: ");
		System.Console.WriteLine(produto1 + ", cujo o preço é $ " + preco1.ToString("F2"));
		System.Console.WriteLine(produto2 + ", cujo o preço é $ " + preco2.ToString("F2"));
		System.Console.WriteLine();
		System.Console.WriteLine("Registro: "+ idade + " anos de idade, código " + codigo + " e gênero: " + genero);
		System.Console.WriteLine();
		System.Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
		System.Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
		System.Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F2", CultureInfo.InvariantCulture));
	}
}