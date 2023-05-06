using System;
using System.Collections.Generic;
using TricoBravo.Model.Enum;

namespace TricoBravo.Model
{
    public class Cliente
    {
        /// <summary>
        /// Id do cliente (obrigatório)';
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome completo do cliente (obrigatório)';
        /// </summary>
        public string NomeCompleto { get; set; }

        /// <summary>
        /// 'Endereço de e-mail do cliente (obrigatório e único)';
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 'Senha do cliente (obrigatória)';
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        ///'Endereço de entrega do cliente (pode ser representado como um array de texto)';
        /// </summary>
        public string EnderecoDeEntrega { get; set; }

        /// <summary>
        ///  'Número de telefone do cliente (obrigatório)';
        /// </summary>
        public string Telefone { get; set; }

        /// <summary>
        /// 'Data de nascimento do cliente (obrigatória)';
        /// </summary>
        public DateTime DataDeNascimento { get; set; }

        /// <summary>
        ///  'Gênero do cliente (obrigatório)';
        /// </summary>
        public GeneroEnum Genero { get; set; }

        /// <summary>
        /// 'Preferências de estilo do cliente (pode ser representado como um array de texto)';
        /// </summary>
        public List<string> PreferenciasDeEstilo { get; set; }

        /// <summary>
        ///  'Tamanho de roupa do cliente';
        /// </summary>
        public string TamanhoDeRoupa { get; set; }

        /// <summary>
        /// Endereço do cliente
        /// </summary>
        public string EnderecoDoCliente { get; set; }
    }
}