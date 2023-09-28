using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using RotaLimpa.Api.Models.Enuns;

namespace RotaLimpa.Api.Models
{
    [Index(nameof(Id_Ruas), IsUnique = true)]
    [PrimaryKey(nameof(Id_Ruas))]
    [Table("Ruas")]
    public class Rua
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id_Ruas")]
        [NotNull]
        public int Id_Ruas { get; set; }

        [Required]
        [ForeignKey("Cep")]
        [NotNull]
        public int Id_Cep { get; set; }
        public CEP Cep { get; set; }

        [Required]
        [ForeignKey("Rotas")]
        [NotNull]
        public int Id_Rota { get; set; }
        public Rota Rota { get; set; }

        public string Nome_Rua { get; set; }
        public string LatInicio { get; set; }
        public string LngInicio { get; set; }
        public string LatFim { get; set; }
        public string LngFim { get; set; }
    }
}
