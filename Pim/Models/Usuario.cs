namespace Pim.Models
{
    public class Usuario
    {
        public int cod_usuario { get; set;}
        public string? nome { get; set;}
        public string? SenhaHash { get; set;}

        public int Nivel { get; set;}
    }
}
