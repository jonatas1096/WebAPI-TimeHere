namespace WebTimeHere.Model
{
    public class Date
    {
        public int id { get; set; }
        public string date { get; set; }
        public double entrada { get; set; }
        public double intervalo { get; set; }
        public double fimIntervalo { get; set; }
        public double saida { get; set; }
        public double horasExtras { get; set; }
        public double horasDevendo { get; set; }
        public string? anotacao { get; set; }
        public int fkFuncionario { get; set; }

    }
}
