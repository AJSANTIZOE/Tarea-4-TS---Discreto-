using System;

class SistemaDiscreto
{
    static void Main()
    {
        // Variables
        string estado = "libre";
        double hora = 8.0;  // Hora de inicio
        bool personas = false;
        
        Console.WriteLine("=== SISTEMA DISCRETO ===");
        Console.WriteLine("Estados: libre, ocupado");
        Console.WriteLine("Variables: hora, personas\n");
        
        // Hora de inicio
        Console.WriteLine($"Hora: {hora:F1} - Estado: {estado}");
        
        // Evento: salon personas (hora de inicio)
        Console.WriteLine("\n[Evento: salon personas]");
        personas = true;
        estado = "ocupado";
        Console.WriteLine($"Hora: {hora:F1} - Estado: {estado} - Personas: {personas}");
        
        // Avanzar tiempo
        hora = 12.0;  // Hora de almuerzo
        Console.WriteLine($"\nHora: {hora:F1} - Estado: {estado}");
        
        // Evento: salon personas (hora de almuerzo)
        Console.WriteLine("\n[Evento: salon personas]");
        personas = false;
        estado = "libre";
        Console.WriteLine($"Hora: {hora:F1} - Estado: {estado} - Personas: {personas}");
        
        Console.WriteLine("\n=== FIN ===");
    }
}