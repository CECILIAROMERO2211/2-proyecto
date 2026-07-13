namespace BienesRaicesWeb.Data
{
   /**
     * @interface IRepository
     * @brief Interfaz genérica para la abstracción del patrón de diseño Repository.
     * @typeparam T Entidad de datos sobre la que se operan transacciones genéricas.
     */
    public interface IRepository<T> where T : class
    {
    }
}