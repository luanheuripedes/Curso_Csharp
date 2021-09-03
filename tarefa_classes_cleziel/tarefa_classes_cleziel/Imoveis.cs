using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace tarefa_classes_cleziel
{
    class Imoveis
    {
        const int ID = 1;
        public string Rua;
        public string Bairro;
        public string Cep;
        public int Numero_casa;
        public int Numero_quartos;
        public int Numero_banheiros;


        public void Cadastrar_Imoveis( string rua, string bairro, string cep, int numero_casa, int numero_quartos, int numero_banheiros)
        {
            
            Rua = rua;
            Bairro = bairro;
            Cep = cep;
            Numero_casa = numero_casa;
            Numero_quartos = numero_quartos;
            Numero_banheiros = numero_banheiros;
        }

        //Alterações
        public void Alterar_rua(string rua)
        {
            Rua = rua;
        }

        public void Alterar_Bairro(string bairro)
        {
            Bairro = bairro;
        }

        public void Alterar_cep(string cep)
        {
            Cep = cep;
        }

        public void Alterar_numero(int numero)
        {
            Numero_casa = numero;
        }

        public void Alterar_quartos(int quartos)
        {
            Numero_quartos = quartos;
        }

        public void Alterar_banheiros(int banheiros)
        {
            Numero_banheiros = banheiros;
        }

        //Consultar
        public void Consultar_casa()
        {
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"Rua:{Rua}");
            Console.WriteLine($"Bairro:{Bairro}");
            Console.WriteLine($"Cep:{Cep}");
            Console.WriteLine($"Numero:{Numero_casa}");
            Console.WriteLine($"Quartos:{Numero_quartos}");
            Console.WriteLine($"Banheiros:{Numero_banheiros}");
        }

        public void Listar_casa()
        {
            Console.WriteLine("Listando casas.......");
        }

        public void Remover_casa()
        {
            Console.WriteLine($"Removendo casa");
        }



    }
}
