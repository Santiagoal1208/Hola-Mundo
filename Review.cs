namespace espacio{
    
    class Review{

        int Calificacion {get; set;}
        string Comentario {get; set;}
        public Review( int calificacion, string comentario){
            this.Calificacion=calificacion;
            this.Comentario=comentario;
        }
        public void Mostrar(){
            Console.WriteLine("calificacion "+this.Calificacion);
            Console.WriteLine("comentario "+this.Comentario);


        }

    }
}