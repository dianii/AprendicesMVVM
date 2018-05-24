using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AprendicesMVVM.Model.Services
{
   public class CaracterizacionAprendices
    {
        public static Data CargarAprendices() {

            ObservableCollection<Aprendiz> aprendices = new ObservableCollection<Aprendiz>();
            Data carAprendices = new Data();
            string[] nombres = {"Oscar","Elkin","Francisco","Victor Manuel","Alejandro","Diana","Oliverio","Mauricio","Jesus" };
            string[] apellidos = { "Ortua", "Garcia", "Martinez", "Lopez", "Gonzalez"};
            string[] programas = { "Contabilidad y Finanzas", "Produccion Multimedia", "ADSI", " Animación 3D", "Diseño Grafico"};
            Random rdn = new Random(DateTime.Now.Millisecond);
            aprendices = new ObservableCollection<Aprendiz>();

            for (int i = 0; i <= 20; i++)
            {
                Aprendiz aprendiz = new Aprendiz();
                aprendiz.Nombre = nombres[rdn.Next(0, 8)];
                aprendiz.Apellido = $"{ apellidos [rdn.Next(0, 4)] }  {apellidos[rdn.Next(0, 4)] }";
                double ficha = rdn.Next(1618618, 2000000);
                aprendiz.Ficha = ficha;
                aprendiz.Programa = programas[rdn.Next(0, 4)];
                aprendiz.Promedio = rdn.Next(100, 1000);
                aprendices.Add(aprendiz);
            }
            carAprendices.Aprendices = aprendices;
            return carAprendices;
        }
    }
}
