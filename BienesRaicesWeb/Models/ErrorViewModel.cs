namespace BienesRaicesWeb.Models
{
    /**
     * @class ErrorViewModel
     * @brief Modelo de datos estructurado para el diagnóstico y control de errores en producción.
     * @details Almacena el RequestId único generado por solicitudes fallidas para la auditoría de los desarrolladores.
     */
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}