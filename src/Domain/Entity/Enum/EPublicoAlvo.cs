using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.Enum;

public enum EPublicoAlvo
{
    [Display(Name = "Estudante")]
    ESTUDANTE = 0,
    [Display(Name = "Universitário")]
    UNIVERSITARIO = 1,
    [Display(Name = "Empregado")]
    EMPREGADO = 2,
    [Display(Name = "Empreendedor")]
    EMPREENDEDOR = 3
}
