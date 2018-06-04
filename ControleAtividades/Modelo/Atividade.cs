namespace Modelo
{
    class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string CtegoriaID { get; set; }

        public virtual Categoria_Categoria { get; set; }

        public int Usuario_Usuario { get; set; }
    }
}
