namespace ApiFestivos.Modelos
{
    
    
        public class Festivo
        {
            public int Id { get; set; }
            public required string Nombre { get; set; } 
            public int Dia { get; set; }
            public int Mes { get; set; }
            public int DiasPascua { get; set; }
            public int TipoId { get; set; }
            public required Tipo Tipo { get; set; } 
        }

    }


