﻿namespace SistemaGestion.Modelos
{
    public class Producto
    {
        private long id;
        private string descripciones;
        private decimal costo;
        private decimal precioVenta;
        private int stock;
        private long idUsuario;

        public long Id { get => id; set => id = value; }

        public decimal Costo { get => costo; set => costo = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Descripciones { get => descripciones; set => descripciones = value; }

        public Producto(long id, string descripciones, decimal costo, decimal precioVenta, int stock, long idUsuario)
        {
            this.id = id;
            this.descripciones = descripciones;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }

        public Producto()
        {
        }
    }
}
