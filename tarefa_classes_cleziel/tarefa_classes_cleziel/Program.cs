using System;

namespace tarefa_classes_cleziel
{
    class Program : Imoveis
    {
        static void Main(string[] args)
        {
            Imoveis c1, c2;
            c1 = new Imoveis();
            c2 = new Imoveis();

            Console.WriteLine("------------------********--------------");
            Console.WriteLine("------------------Cadastrando casa 1--------------");
            Console.WriteLine("Digite a rua da casa: ");
            string rua = Console.ReadLine();

            Console.WriteLine("Digite o bairro da casa: ");
            string bairro = Console.ReadLine();

            Console.WriteLine("Digite o cep da casa : ");
            string cep = Console.ReadLine();

            Console.WriteLine("Digite o numero da casa : ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de quartos : ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de banheiros : ");
            int banheiros = int.Parse(Console.ReadLine());

            c1.Cadastrar_Imoveis(rua,bairro,cep,numero,quartos,banheiros);

            c1.Consultar_casa();

            Console.WriteLine("Quer mudar algum dado da casa? 1-Rua / 2-Bairro / 3-Cep / 4-Numero / 5-Quartos / 6-Banheiros / 7-NÃO");
            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    Console.WriteLine("Digite o novo nome da rua");
                    string nrua =  Console.ReadLine();
                    c1.Alterar_rua(nrua);
                    break;
                case 2:
                    Console.WriteLine("Digite o novo nome do bairro");
                    string nbairro = Console.ReadLine();
                    c1.Alterar_Bairro(nbairro);
                    break;
                case 3:
                    Console.WriteLine("Digite o novo CEP");
                    string ncep = Console.ReadLine();
                    c1.Alterar_cep(ncep);
                    break;
                case 4:
                    Console.WriteLine("Digite o novo Numero");
                    int nnumero = int.Parse(Console.ReadLine());
                    c1.Alterar_numero(nnumero);
                    break;
                case 5:
                    Console.WriteLine("Digite o novo numero de quartos");
                    int nquartos = int.Parse(Console.ReadLine());
                    c1.Alterar_quartos(nquartos);
                    break;
                case 6:
                    Console.WriteLine("Digite o novo numero de banheiros");
                    int nbanheiro = int.Parse(Console.ReadLine());
                    c1.Alterar_numero(nbanheiro);
                    break;
                default:
                    Console.WriteLine("Saiu");
                    break;
            }

            Console.WriteLine("Casa atualizada: ");
            c1.Consultar_casa();

            Console.WriteLine("1 - Listar Casas  / 2 - Remover casa");
            int respostaDois = int.Parse(Console.ReadLine());

            switch (respostaDois)
            {
                case 1:
                    c1.Listar_casa();
                    break;
                case 2:
                    c1.Remover_casa();
                    break;
            }
            Console.WriteLine("------------------********--------------");

            Console.WriteLine("------------------Cadastrando casa 2--------------");
            Console.WriteLine("Digite a rua da casa: ");
            string rua2 = Console.ReadLine();

            Console.WriteLine("Digite o bairro da casa: ");
            string bairro2 = Console.ReadLine();

            Console.WriteLine("Digite o cep da casa : ");
            string cep2 = Console.ReadLine();

            Console.WriteLine("Digite o numero da casa : ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de quartos : ");
            int quartos2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de banheiros : ");
            int banheiros2 = int.Parse(Console.ReadLine());

            c2.Cadastrar_Imoveis(rua2, bairro2, cep2, numero2, quartos2, banheiros2);

            c2.Consultar_casa();

            Console.WriteLine("Quer mudar algum dado da casa? 1-Rua / 2-Bairro / 3-Cep / 4-Numero / 5-Quartos / 6-Banheiros / 7-NÃO");
            int resposta2 = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    Console.WriteLine("Digite o novo nome da rua");
                    string nrua = Console.ReadLine();
                    c2.Alterar_rua(nrua);
                    break;
                case 2:
                    Console.WriteLine("Digite o novo nome do bairro");
                    string nbairro = Console.ReadLine();
                    c2.Alterar_Bairro(nbairro);
                    break;
                case 3:
                    Console.WriteLine("Digite o novo CEP");
                    string ncep = Console.ReadLine();
                    c2.Alterar_cep(ncep);
                    break;
                case 4:
                    Console.WriteLine("Digite o novo Numero");
                    int nnumero = int.Parse(Console.ReadLine());
                    c2.Alterar_numero(nnumero);
                    break;
                case 5:
                    Console.WriteLine("Digite o novo numero de quartos");
                    int nquartos = int.Parse(Console.ReadLine());
                    c2.Alterar_quartos(nquartos);
                    break;
                case 6:
                    Console.WriteLine("Digite o novo numero de banheiros");
                    int nbanheiro = int.Parse(Console.ReadLine());
                    c2.Alterar_numero(nbanheiro);
                    break;
                default:
                    Console.WriteLine("Saiu");
                    break;
            }

            Console.WriteLine("Casa atualizada: ");
            c2.Consultar_casa();

            Console.WriteLine("1 - Listar Casas  / 2 - Remover casa");
            int respostaDois2 = int.Parse(Console.ReadLine());

            switch (respostaDois2)
            {
                case 1:
                    c2.Listar_casa();
                    break;
                case 2:
                    c2.Remover_casa();
                    break;
            }

        }

        

      
    }
}
