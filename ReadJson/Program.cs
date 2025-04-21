using Newtonsoft.Json;
using ReadJson.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        string productosJsonFile = "../../../Productos.json";

        string productosJsonContent = File.ReadAllText(productosJsonFile);

        //if (File.Exists(jsonFilePath))
        //{
        //    string jsonContent = File.ReadAllText(jsonFilePath);
        //    Console.WriteLine("JSON content:");
        //    Console.WriteLine(jsonContent);
        //}
        //else
        //{
        //    Console.WriteLine($"File not found: {jsonFilePath}");
        //}
        //Console.WriteLine("Press any key to exit...");
        //Console.ReadKey();

        List<ProductoModel> productosJson = JsonConvert.DeserializeObject<List<ProductoModel>>(productosJsonContent);

        var productoId4 = productosJson.SingleOrDefault(e => e.Id == 4);

        Console.WriteLine($"Id: {productoId4.Id}, Nombre: {productoId4.Nombre}, Precio: {productoId4.PrecioBase}, Categoria: {productoId4.Categoria}");

        //var query1 = productosJson.Where(e => e.Precio <= 4.95);

        //foreach (var producto in query1)
        //{
        //    Console.WriteLine($"Id: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Categoria: {producto.Categoria}");
        //}

        //var filteredProducts = productosJson.Find(e => e.Id == 1);

        //foreach (var producto in filteredProducts)
        //{
        //    Console.WriteLine($"Id: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Categoria: {producto.Categoria}");
        //}

        Console.ReadKey();
    }
}