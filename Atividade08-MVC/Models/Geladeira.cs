namespace Atividade08_MVC.Models
{
    public class Geladeira : Eletrodomestico
    {
        public int CapacidadeLitros { get; set; }
        public bool TemFreezer { get; set; }

        public override string ExibirDetalhes()
        {
           return $"Marca: {Marca}, Modelo: {Modelo}, kWh: {ConsumoEnergetico}, Capacidade(L): {CapacidadeLitros}, Freezer: {(TemFreezer? "Sim" : "Não")}";
        }
    }
}
