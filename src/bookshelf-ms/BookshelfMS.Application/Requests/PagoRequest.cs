﻿
namespace UCABPagaloTodoMS.Application.Requests
{
    public class PagoRequest
    {
        public string Consumidor { get; set; } = string.Empty;

        public double Monto { get; set; }

        public string Servicio { get; set; } = string.Empty;
    }
}
