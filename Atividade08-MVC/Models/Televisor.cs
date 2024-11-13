namespace Atividade08_MVC.Models
{
    public class Televisor : Eletrodomestico
    {
        public int TamanhoTela { get; set; }
        public bool EhSmart { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, kWh: {ConsumoEnergetico}, Tamanho de Tela: {TamanhoTela},Smart TV: {(EhSmart ? "Sim" : "Não")}";
        }
    }
}
