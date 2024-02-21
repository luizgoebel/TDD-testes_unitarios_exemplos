using Domain.Entity.Enum;

namespace Domain.Entity;

public class Curso(string nome, double cargaHoraria, EPublicoAlvo publicoAlvo, decimal valor)
{
    public string Nome { get; private set; } = nome;
    public double CargaHoraria { get; private set; } = cargaHoraria;
    public EPublicoAlvo PublicoAlvo { get; set; } = publicoAlvo;
    public decimal Valor { get; set; } = valor;
}
