using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Pizzaria.Application.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="É Necessário informar a Rua")]
        [MaxLength(300, ErrorMessage = "Nome da Rua muito grande" )]
        public string Rua { get; set; }

        [Required(ErrorMessage = "É Necessário informar o numero")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "É Necessário informar o Telefone")]
        [Phone(ErrorMessage ="Adicoinar um telefone Válido")]
        public string Telefone1 { get; set; }

        [Phone(ErrorMessage = "Adicoinar um telefone Válido")]
        public string Telefone2 { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "É Necessário informar o Bairro")]
        public  BairroViewModel Bairro { get; set; }

        [Required(ErrorMessage = "É Necessário informar o Municipio")]
        public MunicipioViewModel Municipio { get; set; }

        [Required(ErrorMessage = "É Necessário informar o Uf")]
        public UfViewModel Uf { get; set; }

        [ScaffoldColumn(false)]
        public Guid Id_Conta{ get; set; }

        [ScaffoldColumn(false)]
        public Guid Id_Bairro { get; set; }

        [ScaffoldColumn(false)]
        public Guid Id_Uf{ get; set; }

        [ScaffoldColumn(false)]
        public Guid Id_Municipio { get; set; }


    }
}