namespace espacio{

    class Producto{
        string Nombre {get; set;}
        int Precio {get; set;}
        List<Review> Reviews {get; set;}
        
        public Producto( string nombre,int precio){
            this.Reviews = new List<Review>();
            this.Nombre=nombre;
            this.Precio=precio;

        }
        public void AgregarReview(Review review){
            //List<Review> reviews =new List<Review>(this.Reviews);

            //reviews.Add(review);

            this.Reviews.Add(review);
        }

        public void MostrarReviews(){
            foreach (Review i in this.Reviews){
                i.Mostrar();
            }


        }
    }
}