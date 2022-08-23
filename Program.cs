// See https://aka.ms/new-console-template for more information


namespace espacio{

    class MainApp{

        public static void Main(){
            Producto p1 = new Producto("anillo",390);
        Review rev1 = new Review(3, "orrible");
        Review rev2 = new Review(5, "peor");
        Review rev3 = new Review(1, "es lo mejor que he comprado");

        List<Review> lista =new List<Review>();
        lista.Add(rev1);
        lista.Add(rev2);
        lista.Add(rev3);
        p1.AgregarReview(rev1);
        p1.AgregarReview(rev2);
        p1.MostrarReviews();
        }
    }
    
}

    
