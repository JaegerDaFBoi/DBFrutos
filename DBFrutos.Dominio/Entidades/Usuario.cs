namespace DBFrutos.Dominio
{
    public class Usuario 
    {
        public int Id { get; set; }
        public TipoUsuario Tipousuario { get; set; }
        public string Nombre { get; set; }
        public int Documento { get; set; }
        public bigint Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        
    }
}