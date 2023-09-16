using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPreParcial.Entities
{
    internal class Equipo
    {
        public string Pais { get; set; }
        public string DirectorTecnico { get; set; }

        public List<Jugador> JugadorList = new List<Jugador>();



        public void AgregarJugador(Jugador jugador)
        {
            JugadorList.Add(jugador);  
        }

        public void QuitarJugador(int index)
        {
            for(int i = 0; i < JugadorList.Count; i++)
            {
                if (JugadorList[i].Persona.id == index)
                {
                    JugadorList.RemoveAt(i);
                    break;
                }
            }
        }


    }
}
