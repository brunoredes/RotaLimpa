using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using RotaLimpa.Api.Models.Enuns;

namespace RotaLimpa.Api.Models
{
    [Index(nameof(Id_Setor), IsUnique = true)]
    [PrimaryKey(nameof(Id_Setor))]
    [Table("Setores")]
    public class Setor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id_Setor")]
        public int Id_Setor { get; set; }

        [Required]
        [ForeignKey("Colaboradores")]
        public int Id_Colaborador { get; set; }
        public Colaborador Colaborador { get; set; }

        [Required]
        [ForeignKey("Empresas")]
        [NotNull]
        public int Id_Empresa { get; set; }
        public Empresa Empresa { get; set; }

        [Required]
        [Column("Servico")]
        [NotNull]
        public TiposServicos Servico { get; set; }

        [Required]
        [Column("Di_Setor")]
        public DateTime Di_Setor { get; set; }

        [Required]
        [Column("Da_Setor")]
        public DateTime Da_Setor { get; set; }

        [Required]
        [StringLength(255)]
        [Column("St_Setor")]
        public String St_Setor { get; set; }
    }
}


